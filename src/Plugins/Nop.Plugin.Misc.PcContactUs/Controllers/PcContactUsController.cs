using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Domain.Messages;
using Nop.Core.Domain.Security;
using Nop.Services.Customers;
using Nop.Services.Messages;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using Nop.Web.Framework.Security.Captcha;
using Nop.Services.Logging;
using Nop.Plugin.Misc.PcContactUs.Models;
using Nop.Services.Localization;
using Nop.Services.Configuration;
using System.Threading.Tasks;
using Nop.Plugin.Misc.PcContactUs.Factories;
using Nop.Services.Html;
using Nop.Web.Framework;
using Microsoft.Extensions.Primitives;

namespace Nop.Plugin.Misc.PcContactUs.Controllers
{
    public class PcContactUsController : BasePluginController
    {
        private readonly IWorkContext _workContext;
        private readonly ICommonModelFactory _commonModelFactory;
        private readonly ICustomerActivityService _customerActivityService;
        private readonly IHtmlFormatter _htmlFormatter;
        private readonly EmailAccountSettings _emailAccountSettings;
        private readonly IEmailAccountService _emailAccountService;
        private readonly IEmailSender _emailSender;
        private readonly IQueuedEmailService _queuedEmailService;
        private readonly IMessageTemplateService _messageTemplateService;
        private readonly IWorkflowMessageService _workflowMessageService;
        private readonly ContactUsSettings _contactUsSettings;
        private readonly CaptchaSettings _captchaSettings;
        private readonly ContactUsSettings _settings;
        private readonly ICustomerService _customerService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly CaptchaHttpClient _captchaHttpClient;
        private readonly ILogger _logger;
        private readonly INotificationService _notificationService;
        private readonly ILocalizationService _localizationService;
        private readonly ISettingService _settingService;
        private readonly IStoreContext _storeContext;
        private readonly IMessageTokenProvider _messageTokenProvider;
        private readonly ITokenizer _tokenizer;

        public PcContactUsController(
            IWorkContext workContext,
            ICommonModelFactory commonModelFactory,
            ICustomerActivityService customerActivityService,
            IHtmlFormatter htmlFormatter,
            EmailAccountSettings emailAccountSettings,
            IEmailAccountService emailAccountService,
            IEmailSender emailSender,
            IQueuedEmailService queuedEmailService,
            IMessageTemplateService messageTemplateService,
            IWorkflowMessageService workflowMessageService,
            ContactUsSettings contactUsSettings,
            CaptchaSettings captchaSettings,
            ContactUsSettings settings,
            ICustomerService customerService,
            IHttpContextAccessor httpContextAccessor,
            CaptchaHttpClient captchaHttpClient,
            ILogger logger,
            INotificationService notificationService,
            ILocalizationService localizationService,
            ISettingService settingService,
            IStoreContext storeContext,
            IMessageTokenProvider messageTokenProvider,
            ITokenizer tokenizer)
        {
            _workContext = workContext;
            _commonModelFactory = commonModelFactory;
            _customerActivityService = customerActivityService;
            _htmlFormatter = htmlFormatter;
            _emailAccountSettings = emailAccountSettings;
            _emailAccountService = emailAccountService;
            _emailSender = emailSender;
            _queuedEmailService = queuedEmailService;
            _messageTemplateService = messageTemplateService;
            _workflowMessageService = workflowMessageService;
            _contactUsSettings = contactUsSettings;
            _captchaSettings = captchaSettings;
            _settings = settings;
            _customerService = customerService;
            _httpContextAccessor = httpContextAccessor;
            _captchaHttpClient = captchaHttpClient;
            _logger = logger;
            _notificationService = notificationService;
            _localizationService = localizationService;
            _settingService = settingService;
            _storeContext = storeContext;
            _messageTokenProvider = messageTokenProvider;
            _tokenizer = tokenizer;
        }
        
        [AuthorizeAdmin]
        [Area(AreaNames.ADMIN)]
        public IActionResult Configure()
        {
            return View(
                "~/Plugins/Misc.PcContactUs/Views/Configure.cshtml",
                _contactUsSettings.ToModel()
            );
        }
        
        [HttpPost]
        [AuthorizeAdmin]
        [Area(AreaNames.ADMIN)]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Configure(ContactUsConfigModel model)
        {
            await _settingService.SaveSettingAsync(ContactUsSettings.FromModel(model));
            _notificationService.SuccessNotification(await _localizationService.GetResourceAsync("Admin.Plugins.Saved"));

            return Configure();
        }

        public virtual async Task<IActionResult> PcContactUs()
        {
            var model = new ContactUsModel();
            model = await _commonModelFactory.PrepareContactUsModelAsync(model, false);
        
            return View("~/Plugins/Misc.PcContactUs/Views/PcContactUs/PcContactUs.cshtml", model);
        }
        
        [HttpPost, ActionName("PcContactUs")]
        [ValidateCaptcha]
        public virtual async Task<IActionResult> PcContactUsSend(ContactUsModel model, bool captchaValid)
        {

            var resultModel = new ContactUsResultModel();

            //validate CAPTCHA
            //if (_captchaSettings.Enabled)
            //{
            //    //var gCaptchaResponseValue = model.GRecaptchaResponse;
            //    var gCaptchaResponseValue = Request.Form["g-recaptcha-response"].ToString();
            //    if (StringValues.IsNullOrEmpty(gCaptchaResponseValue))
            //    {
            //        return BadRequest("CAPTCHA response not provided.");
            //    }

            //    var response = await _captchaHttpClient.ValidateCaptchaAsync(gCaptchaResponseValue);
            //    if (!response.IsValid)
            //    {
            //        return BadRequest("CAPTCHA response invalid.");
            //    }
            //}

            //validate CAPTCHA
            if (_captchaSettings.Enabled && _captchaSettings.ShowOnContactUsPage && !captchaValid)
            {
                ModelState.AddModelError("", await _localizationService.GetResourceAsync("Common.WrongCaptchaMessage"));
            }

            model = await _commonModelFactory.PrepareContactUsModelAsync(model, true);

            model.DisplayCaptcha = _captchaSettings.Enabled;

            if (ModelState.IsValid)
            {
                var account = await _emailAccountService.GetEmailAccountByIdAsync(4); // pcinquiry@portlandcompressor.com
                var ccEmails = new List<string>(_contactUsSettings.AdditionalEmails.Split(','));
                var toAddress = _contactUsSettings.ContactUsEmail;
                var fromAddress = _contactUsSettings.ContactUsEmail;
                // await _messageTokenProvider.AddStoreTokensAsync(commonTokens, await _storeContext.GetCurrentStoreAsync(), account);
                // var toEmail = emailAccount.Email;
                // var body = _htmlFormatter.FormatText(model.Comments, false, true, false, false, false, false);
                 var body = string.Format(
                     @"A request has been submitted with an inquiry from the Contact us page. <br/><br/>

                     Customer Name: {0} <br/>
                     Customer Email: {1} <br/>
                     Customer Phone Number: {2} <br/>
                     Comments: {3}", model.Name ?? "", model.Email ?? "", model.PhoneNumber ?? "", _htmlFormatter.FormatText(model.Comments, false, true, false, false, false, false) ?? ""
                 );
                
                // works
                // await _workflowMessageService.SendNotificationAsync(messageTemplate, emailAccount, (await _workContext.GetWorkingLanguageAsync()).Id, commonTokens, toEmail, model.Name, null, null, model.Email, model.Name, model.Email, model.Name, subject: "Portland Compressor. Contact Us");

                // use queued email instead of _emailSender
                var email = new QueuedEmail
                {
                    Priority = QueuedEmailPriority.High,
                    From = fromAddress,
                    FromName = account.DisplayName,
                    To = toAddress,
                    ReplyTo = model.Email,
                    ReplyToName = model.Name,
                    CC = string.Join(",", ccEmails),
                    Subject = "Portland Compressor. Contact Us.",
                    Body = body,
                    CreatedOnUtc = DateTime.UtcNow,
                    EmailAccountId = account.Id,
                    DontSendBeforeDateUtc = null,
                };
                
                // use queued email instead of _emailSender
                await _queuedEmailService.InsertQueuedEmailAsync(email);

                model.SuccessfullySent = true;
                model.Result = await _localizationService.GetResourceAsync("ContactUs.YourEnquiryHasBeenSent");

                //activity log
                await _customerActivityService.InsertActivityAsync("PublicStore.ContactUs",
                    await _localizationService.GetResourceAsync("ActivityLog.PublicStore.ContactUs"));

                return View("~/Plugins/Misc.PcContactUs/Views/PcContactUs/PcContactUs.cshtml", model);
            }
            return View("~/Plugins/Misc.PcContactUs/Views/PcContactUs/PcContactUs.cshtml", model);
        }
    }
}

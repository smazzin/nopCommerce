using Nop.Core;
using Nop.Services.Localization;
using Nop.Services.Configuration;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;
using System.Collections.Generic;
using Nop.Services.Common;
using Task = System.Threading.Tasks.Task;
using Nop.Core.Domain.Cms;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.PcContactUs
{
    public class ContactUs : BasePlugin, IMiscPlugin
    {
        private readonly ILocalizationService _localizationService;
        private readonly ISettingService _settingService;
        private readonly IWebHelper _webHelper;

        public ContactUs(
            ILocalizationService localizationService,
            ISettingService settingService,
            IWebHelper webHelper,
            WidgetSettings widgetSettings
        )
        {
            _localizationService = localizationService;
            _settingService = settingService;
            _webHelper = webHelper;
        }
        public override string GetConfigurationPageUrl()
        {
            return $"{_webHelper.GetStoreLocation()}Admin/PcContactUs/Configure";
        }

        public override async Task InstallAsync()
        {
            await UpdateLocales();
            await _settingService.SaveSettingAsync(ContactUsSettings.Default());
            await base.InstallAsync();
        }
        
        public override async Task UninstallAsync()
        {
            await _localizationService.DeleteLocaleResourcesAsync(ContactUsLocaleKeys.ContactUsEmail);
            await _localizationService.DeleteLocaleResourcesAsync(ContactUsLocaleKeys.AdditionalEmails);

            await base.UninstallAsync();
        }

        public Task<IList<string>> GetWidgetZonesAsync()
        {
            return Task.FromResult<IList<string>>(new List<string>
            {
                PublicWidgetZones.ContactUsTop
            });
        }

        public override async Task UpdateAsync(string oldVersion, string currentVersion)
        {
            await UpdateLocales();
        }
        
        private async Task UpdateLocales()
        {
            await _localizationService.AddOrUpdateLocaleResourceAsync(
                new Dictionary<string, string>
                {
                    [ContactUsLocaleKeys.ContactUsEmail] = "Contact Us Email",
                    [ContactUsLocaleKeys.AdditionalEmails] = "Additional Emails",
                });
        }
    }
}
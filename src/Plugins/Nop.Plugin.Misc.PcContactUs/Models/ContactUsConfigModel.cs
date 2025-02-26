using Nop.Web.Framework.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Nop.Plugin.Misc.PcContactUs.Models
{
    public class ContactUsConfigModel
    {
        [Required]
        [NopResourceDisplayName(ContactUsLocaleKeys.ContactUsEmail)]
        public string ContactUsEmail { get; set; }

        [NopResourceDisplayName(ContactUsLocaleKeys.AdditionalEmails)]
        public string AdditionalEmails { get; set; }
    }
}
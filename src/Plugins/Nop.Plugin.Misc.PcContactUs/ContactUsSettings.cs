using Nop.Core.Configuration;
using Nop.Plugin.Misc.PcContactUs.Models;
using System;

namespace Nop.Plugin.Misc.PcContactUs
{
    public class ContactUsSettings : ISettings
    {
        public string ContactUsEmail { get; private set; }
        public string AdditionalEmails { get; private set; }
        public bool IsEmailSubmissionSkipped { get; private set; }

        internal static ContactUsSettings FromModel(ContactUsConfigModel model)
        {
            return new ContactUsSettings()
            {
                ContactUsEmail = model.ContactUsEmail,
                AdditionalEmails = model.AdditionalEmails,
            };
        }

        public ContactUsConfigModel ToModel()
        {
            return new ContactUsConfigModel()
            {
                ContactUsEmail = ContactUsEmail,
                AdditionalEmails = AdditionalEmails,
            };
        }

        internal static ContactUsSettings Default()
        {
            return new ContactUsSettings()
            {
                AdditionalEmails = ""
            };
        }
    }
}
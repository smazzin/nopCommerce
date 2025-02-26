using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nop.Plugin.Misc.PcContactUs.Models
{
    public record ContactUsModel : BaseNopModel

    {
        public ContactUsModel()
        {
            ErrorMessages = new List<string>();
        }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Comments { get; init; }

        public List<string> ErrorMessages { get; set; } = new();

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }
        public string GRecaptchaResponse { get; set; }
    }
}
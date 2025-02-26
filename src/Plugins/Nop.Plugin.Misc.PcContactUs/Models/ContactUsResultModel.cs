using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nop.Plugin.Misc.PcContactUs.Models
{
    public record ContactUsResultModel : BaseNopModel
    {
        public List<string> ErrorMessages { get; set; }

        public ContactUsResultModel()
        {
            ErrorMessages = new List<string>();
        }
    }
}
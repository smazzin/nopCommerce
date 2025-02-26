using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Orders;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace PortlandCompressor.Plugin.Widgets.GA4.Models
{
    public class GA4GeneralModel
    {
        public decimal Value { get; init; }
        public IList<GA4OrderItem> Items { get; init; }
    }
}

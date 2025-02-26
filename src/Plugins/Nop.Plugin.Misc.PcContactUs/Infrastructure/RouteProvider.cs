using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Misc.PcContactUs.Infrastructure
{
    /// <summary>
    /// Represents plugin route provider
    /// </summary>
    public class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {

            // endpointRouteBuilder.MapControllerRoute("PcContactUs",
            //     "PcContactUs/DisplayContactUs",
            //     new
            //     {
            //         controller = "PcContactUs",
            //         action = "DisplayContactUs"
            //     });
            
            endpointRouteBuilder.MapControllerRoute("ContactUs",
                "contactus",
                new { controller = "PcContactUs", action = "PcContactUs" });
        }
        
        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 100;
    }
}
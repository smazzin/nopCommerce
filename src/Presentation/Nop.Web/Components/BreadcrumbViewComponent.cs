using Microsoft.AspNetCore.Mvc.Infrastructure;
using Nop.Web.Controllers;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using System;

namespace Nop.Web.Components
{
    public class BreadcrumbViewComponent : NopViewComponent
    {
        private readonly IActionDescriptorCollectionProvider _actionDescriptorCollectionProvider;

        public BreadcrumbViewComponent(IActionDescriptorCollectionProvider actionDescriptorCollectionProvider)
        {
            _actionDescriptorCollectionProvider = actionDescriptorCollectionProvider;
        }

        public IViewComponentResult Invoke()
        {
            var breadcrumbs = new List<(string Url, string Name)>();
            var currentPath = HttpContext.Request.Path.Value.Trim('/');

            // Start with the Home breadcrumb
            breadcrumbs.Add(("/", "Home"));

            // Build dynamic breadcrumbs based on the current path
            BuildBreadcrumbs(currentPath, breadcrumbs);

            return View(breadcrumbs);
        }

        private void BuildBreadcrumbs(string currentPath, List<(string Url, string Name)> breadcrumbs)
        {
            string[] segments = currentPath.Split('/');
            string cumulativePath = string.Empty;

            foreach (var segment in segments)
            {
                cumulativePath += "/" + segment;
                var actionDescriptor = _actionDescriptorCollectionProvider.ActionDescriptors.Items
                    .FirstOrDefault(ad => ad.AttributeRouteInfo != null &&
                                          ("/" + ad.AttributeRouteInfo.Template.Trim('/')).Equals(cumulativePath, StringComparison.OrdinalIgnoreCase));

                string displayName = segment; // Default to segment name if no attribute found
                if (actionDescriptor != null)
                {
                    displayName = actionDescriptor.EndpointMetadata
                        .OfType<RouteNameAttribute>()
                        .FirstOrDefault()?.Name ?? displayName;
                }

                breadcrumbs.Add((cumulativePath, displayName));
            }
        }
    }
}
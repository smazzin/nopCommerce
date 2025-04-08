using Microsoft.AspNetCore.Mvc.Infrastructure;
using Nop.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Services.Stores;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public partial class NavigationViewComponent : NopViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly IStoreMappingService _storeMappingService;
        
        private readonly IActionDescriptorCollectionProvider _actionDescriptorCollectionProvider;
        private readonly Dictionary<string, List<string>> _controllerRelationships = new Dictionary<string, List<string>>
        {
            { "Airless", new List<string> { "AirlessBreakdowns", "WagnerSprayTech" } },
            { "Compressor", new List<string> { "CampbellHausfeld", "ChicagoPneumatic", "IngersollRand", "Jenny", "RolAir" } },
            { "Stripers", new List<string> { "LineStriperBreakdowns" } }
        };

        public NavigationViewComponent(IActionDescriptorCollectionProvider actionDescriptorCollectionProvider,
            IStoreContext storeContext,
            IStoreMappingService storeMappingService
        )
        {
            _actionDescriptorCollectionProvider = actionDescriptorCollectionProvider;
            _storeContext = storeContext;
            _storeMappingService = storeMappingService;
        }

        public IViewComponentResult Invoke()
        {
            var currentController = RouteData.Values["controller"]?.ToString();
            var currentUrl = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}{HttpContext.Request.Path}";
            var structure = BuildControllerLinkStructure(currentController);
            var model = (structure, currentUrl);
            return View(model);
        }

        private Dictionary<string, List<(string Url, string Name)>> BuildControllerLinkStructure(string currentController)
        {
            var structure = new Dictionary<string, List<(string Url, string Name)>>();

            // Add parent controller
            structure[currentController] = GetControllerLinks(new List<string> { currentController });

            // Add related controllers
            if (_controllerRelationships.TryGetValue(currentController, out var relatedControllers))
            {
                foreach (var controller in relatedControllers)
                {
                    structure[controller] = GetControllerLinks(new List<string> { controller });
                }
            }

            return structure;
        }

        private List<(string Url, string Name)> GetControllerLinks(List<string> controllers)
        {
            var store = _storeContext.GetCurrentStore();
            var currentStoreUrl = store.Url;
            var links = new List<(string Url, string Name)>();
            var baseUri = new Uri(currentStoreUrl);
            
            var actions = _actionDescriptorCollectionProvider.ActionDescriptors.Items;
            foreach (var action in actions)
            {
                var controllerName = action.RouteValues["Controller"];
                if (controllers.Contains(controllerName))
                {
                    var template = action.AttributeRouteInfo?.Template;
                    if (!string.IsNullOrEmpty(template))
                    {
                        var fullUrl = new Uri(baseUri, template).AbsoluteUri;
                        var displayName = action.EndpointMetadata
                                            .OfType<RouteNameAttribute>()
                                            .FirstOrDefault()?.Name ?? template;  // Fallback to the template if no name provided
                        links.Add((fullUrl, displayName));
                    }
                }
            }

            return links;
        }
    }
}

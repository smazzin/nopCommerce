using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace Nop.Web.Controllers
{
    public class StaticPagesSitemapController : Controller
    {
        private readonly IActionDescriptorCollectionProvider _actionDescriptorCollectionProvider;

        public StaticPagesSitemapController(IActionDescriptorCollectionProvider actionDescriptorCollectionProvider)
        {
            _actionDescriptorCollectionProvider = actionDescriptorCollectionProvider;
        }

        public IActionResult Index()
        {
            var urls = GetSitemapUrls();
            var sitemapXml = GenerateSitemapXml(urls);

            if (sitemapXml == null)
            {
                // Logging the error or handling it as necessary
                return StatusCode(500, "Sitemap generation failed.");
            }

            return Content(sitemapXml.ToString(), "text/xml");
        }

        private List<string> GetSitemapUrls()
        {
            var urls = new List<string>();
            var baseUri = new Uri("https://www.portlandcompressor.com/"); // Set your base URI here

            // Ensure base url is included in sitemap
            var customUrl = "https://www.portlandcompressor.com/";
            urls.Add(customUrl); // Add at the beginning or move this line to add at the end after all other URLs are added

            var includedControllers = new HashSet<string>
            {
                "HomePC",
                "Airless", 
                "AirlessBreakdowns", 
                "CampbellHausfeld",
                "ChicagoPneumatic",
                "Compressor",
                "Hvlp",
                "IngersollRand",
                "Jenny",
                "LineStriperBreakdowns",
                "PressureWashers",
                "RolAir",
                "Stripers",
                "TextureSprayers",
                "WagnerSprayTech"
            };

            // Get all routes from action descriptors
            var actions = _actionDescriptorCollectionProvider.ActionDescriptors.Items;
            foreach (var action in actions)
            {
                var controllerName = action.RouteValues["Controller"];
                if (includedControllers.Contains(controllerName)) // Filter for specific controllers
                {
                    var template = action.AttributeRouteInfo?.Template;
                    if (!string.IsNullOrEmpty(template))
                    {
                        var fullUrl = new Uri(baseUri, template).AbsoluteUri;
                        urls.Add(fullUrl);
                    }
                }
            }

            return urls;
        }


        private XDocument GenerateSitemapXml(List<string> urls)
        {
            if (urls == null || !urls.Any())
            {
                // Return null if no URLs are present, or handle accordingly
                return null;
            }

            XNamespace xmlns = "http://www.sitemaps.org/schemas/sitemap/0.9";
            XNamespace xsi = "http://www.w3.org/2001/XMLSchema-instance";

            var sitemapXml = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
                new XElement(xmlns + "urlset",
                    new XAttribute(XNamespace.Xmlns + "xsi", xsi.NamespaceName),
                    new XAttribute(xsi + "schemaLocation", "http://www.sitemaps.org/schemas/sitemap/0.9 http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd")
                ));

            foreach (var url in urls)
            {
                var urlElement = new XElement(xmlns + "url",
                    new XElement(xmlns + "loc", url)
                    // new XElement(xmlns + "lastmod", DateTime.UtcNow.ToString("yyyy-MM-dd"))
                    // new XElement(xmlns + "changefreq", "daily"),
                    // new XElement(xmlns + "priority", "1.0")
                );

                sitemapXml.Root.Add(urlElement);
            }

            return sitemapXml;
        }
    }
}

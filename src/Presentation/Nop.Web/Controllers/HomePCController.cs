using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("")]
    public class HomePCController : Controller
    {
        // GET: Home
        [Route("")]
        public IActionResult Index()
        {

            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("customer-service")]
        public IActionResult CustomerService()
        {
            return View();
        }

        [Route("faq")]
        public IActionResult Faq()
        {
            return View();
        }

        [Route("newsletter-signup")]
        public IActionResult NewsletterSignup()
        {
            return View();
        }

        [Route("acclaim")]
        public IActionResult Acclaim()
        {
            return View();
        }

        [Route("oregon-cities")]
        public IActionResult OregonCities()
        {
            return View();
        }

        [Route("portland-oregon")]
        public IActionResult PortlandOregon()
        {
            return View();
        }

        [Route("salestax")]
        public IActionResult Salestax()
        {
            return View();
        }

        // [Route("search")]
        // public IActionResult Search()
        // {

        //     return View();

        // }

        [Route("search2")]
        public IActionResult Search2()
        {
            return View();
        }

        [Route("service-repair")]
        public IActionResult ServiceRepair()
        {
            return View();
        }

        [Route("service-specials")]
        public IActionResult ServiceSpecials()
        {
            return View();
        }

        [Route("shipping")]
        public IActionResult Shipping()
        {
            return View();
        }

        [Route("sitemap")]
        public IActionResult Sitemap()
        {
            return View();
        }

        [Route("social-networking")]
        public IActionResult SocialNetworking()
        {
            return View();
        }

        [Route("tracking")]
        public IActionResult Tracking()
        {
            return View();
        }

        [Route("jobs-employment")]
        public IActionResult JobsEmployment()
        {
            return View();
        }

        [Route("jobs-employment-cashier")]
        public IActionResult JobsEmploymentCashier()
        {
            return View();
        }

        [Route("jobs-employment-field-technician")]
        public IActionResult JobsEmploymentFieldTechnician()
        {
            return View();
        }


        [Route("jobs-employment-parts-counter")]
        public IActionResult JobsEmploymentPartsCounter()
        {
            return View();
        }

        [Route("jobs-employment-service-coordinator")]
        public IActionResult JobsEmploymentServiceCoordinator()
        {
            return View();
        }
    
        [Route("jobs-employment-warehouse-freight-shipping")]
        public IActionResult JobsEmploymentWarehouseFreightShipping()
        {
            return View();
        }

        [Route("inside-service-technician")]
        public IActionResult JobsEmploymentInsideServiceTechnician()
        {
            return View();
        }


    }
}
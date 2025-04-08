using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("airless/wagner-spraytech")]
    public class WagnerSprayTechController : Controller
    {
        // GET: Wagner_SprayTech
        [Route("")]
        [RouteName("Wagner SprayTech")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: company-history
        [Route("company-history")]
        [RouteName("Company History")]
        public ActionResult CompanyHistory()
        {
            return View();
        }

        // GET: compare-ProForce-sprayers
        [Route("compare-proforce-sprayers")]
        [RouteName("Compare ProForce Sprayers")]
        public ActionResult CompareProForceSprayers()
        {
            return View();
        }

        // GET: ProForce-23-Cleaning
        [Route("proforce-23-cleaning")]
        [RouteName("SprayTech PF23 Cleaning")]
        public ActionResult ProForce23Cleaning()
        {
            return View();
        }

        // GET: ProForce-23-Storage
        [Route("proforce-23-storage")]
        [RouteName("SprayTech PF23 Storage")]
        public ActionResult ProForce23Storage()
        {
            return View();
        }

        // GET: ProForce-23
        [Route("proforce-23")]
        [RouteName("Wagner SprayTech PF23 Airless Paint Sprayer")]
        public ActionResult ProForce23()
        {
            return View();
        }

        // GET: ProForce-Paint-Crew
        [Route("proforce-paint-crew")]
        [RouteName("ProForce Paint Crew")]
        public ActionResult ProForcePaintCrew()
        {
            return View();
        }

        // GET: ProForce-parts
        [Route("proforce-parts")]
        [RouteName("ProForce Parts")]
        public ActionResult ProForceParts()
        {
            return View();
        }
    }
}
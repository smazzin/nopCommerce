using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("stripers")]
    public class StripersController : Controller
    {
        // GET: Stripers
        [Route("")]
        [RouteName("Line Stripers")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: compare-linelazer-stripers-archive
        [Route("compare-linelazer-stripers-archive")]
        [RouteName("Compare Past Graco LineLazer IV Stripers")]
        public ActionResult CompareLinelazerStripersArchive()
        {
            return View();
        }

        // GET: Compare-linelazer-Stripers
        [Route("compare-linelazer-stripers")]
        [RouteName("Compare Graco Line Stripers")]
        public ActionResult CompareLineLazerStripers()
        {
            return View();
        }

        // GET: discontinued-Graco-stripers
        [Route("discontinued-graco-stripers")]
        [RouteName("Discontinued Graco Line Stripers")]
        public ActionResult DiscontinuedGracoStripers()
        {
            return View();
        }

        // GET: FAQ
        [Route("faq")]
        [RouteName("Line Striper FAQ")]
        public ActionResult FAQ()
        {
            return View();
        }

        // GET: FieldLazer
        [Route("fieldlazer")]
        [RouteName("Graco FieldLazer")]
        public ActionResult FieldLazer()
        {
            return View();
        }

        // GET: glossary
        [Route("glossary")]
        [RouteName("Line Striper Glossary")]
        public ActionResult Glossary()
        {
            return View();
        }

        // GET: Graco-GrindLazers
        [Route("graco-grindlazers")]
        [RouteName("Graco GrindLazers")]
        public ActionResult GracoGrindLazers()
        {
            return View();
        }

        // GET: Graco-ThermoLazer-dies
        [Route("graco-thermolazer-dies")]
        [RouteName("Graco ThermoLazer Dies")]
        public ActionResult GracoThermoLazerDies()
        {
            return View();
        }

        // GET: Graco-ThermoLazer
        [Route("graco-thermolazer")]
        [RouteName("Graco ThermoLazer")]
        public ActionResult GracoThermoLazer()
        {
            return View();
        }

        // GET: GrindLazer-Cutters
        [Route("grindlazer-cutters")]
        [RouteName("Graco GrindLazer Cutters")]
        public ActionResult GrindLazerCutters()
        {
            return View();
        }

        // GET: linelazer-Accessories
        [Route("linelazer-accessories")]
        [RouteName("Line Striper Accessories")]
        public ActionResult LineLazerAccessories()
        {
            return View();
        }

        // GET: linelazer-Auto-Layout-System
        [Route("linelazer-auto-layout-system")]
        [RouteName("Graco Line Striper Auto Layout System")]
        public ActionResult LineLazerAutoLayoutSystem()
        {
            return View();
        }

        // GET: linelazer-Parts
        [Route("linelazer-parts")]
        [RouteName("Line Striper Parts")]
        public ActionResult LineLazerParts()
        {
            return View();
        }

        // GET: linelazer-Stripers
        [Route("linelazer-stripers")]
        [RouteName("Graco LineLazer Stripers")]
        public ActionResult LineLazerStripers()
        {
            return View();
        }

        // GET: linelazer-tips
        [Route("linelazer-tips")]
        [RouteName("Line Striper Tips")]
        public ActionResult LineLazerTips()
        {
            return View();
        }

        // GET: linelazer-trouble-shooting
        [Route("linelazer-trouble-shooting")]
        [RouteName("Line Striper Trouble Shooting")]
        public ActionResult LineLazerTroubleShooting()
        {
            return View();
        }
    }
}
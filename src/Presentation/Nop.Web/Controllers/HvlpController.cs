using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("hvlp")]
    public class HvlpController : Controller
    {
        [Route("")]
        [RouteName("HVLP")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Frequenlty-Asked-Questions
        [Route("frequenlty-asked-questions")]
        [RouteName("HVLP FAQ")]
        public ActionResult FrequenltyAskedQuestions()
        {
            return View();
        }

        // GET: graco-hvlp-parts-accessories-prior
        [Route("graco-hvlp-parts-accessories-prior")]
        [RouteName("Past HVLP Parts & Accessories")]
        public ActionResult GracoHvlpPartsAccessoriesPrior()
        {
            return View();
        }

        // GET: graco-hvlp-parts-accessories
        [Route("graco-hvlp-parts-accessories")]
        [RouteName("HVLP Parts & Accessories")]
        public ActionResult GracoHvlpPartsAccessories()
        {
            return View();
        }

        // GET: graco-hvlp-Sprayers-prior
        [Route("graco-hvlp-sprayers-prior")]
        [RouteName("Past Graco HVLP Sprayers")]
        public ActionResult GracoHvlpSprayersPrior()
        {
            return View();
        }

        // GET: graco-hvlp-Sprayers
        [Route("graco-hvlp-sprayers")]
        [RouteName("Graco HVLP Sprayers")]
        public ActionResult GracoHvlpSprayers()
        {
            return View();
        }

        // GET: trouble-shooting
        [Route("trouble-shooting")]
        [RouteName("HVLP Trouble Shooting")]
        public ActionResult TroubleShooting()
        {
            return View();
        }
    }
}
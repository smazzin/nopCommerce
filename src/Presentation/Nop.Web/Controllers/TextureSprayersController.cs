using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("texture-sprayers")]
    public class TextureSprayersController : Controller
    {
        // GET: Texture_Sprayers
        [Route("")]
        [RouteName("Texture Sprayers")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Airlessco-Texture-Sprayers
        [Route("airlessco-texture-sprayers")]
        [RouteName("Airlessco Texture Sprayers")]
        public ActionResult AirlesscoTextureSprayers()
        {
            return View();
        }

        // GET: Application-Guide
        [Route("application-guide")]
        [RouteName("Texture Application Guide")]
        public ActionResult ApplicationGuide()
        {
            return View();
        }

        // GET: Cleaning-and-Storage
        [Route("cleaning-and-storage")]
        [RouteName("Cleaning and Storage")]
        public ActionResult CleaningAndStorage()
        {
            return View();
        }

        // GET: Compare-Graco-TexSpray-Archive
        [Route("compare-graco-texspray-archive")]
        [RouteName("Compare Past Graco TexSpray Models")]
        public ActionResult CompareGracoTexSprayArchive()
        {
            return View();
        }

        // GET: Compare-Graco-TexSpray
        [Route("compare-graco-texspray")]
        [RouteName("Compare Graco TexSpray Models")]
        public ActionResult CompareGracoTexSpray()
        {
            return View();
        }

        // GET: glossary
        [Route("glossary")]
        public ActionResult Glossary()
        {
            return View();
        }

        // GET: Graco-Texspray-Accessories
        [Route("graco-texspray-accessories")]
        [RouteName("Graco TexSpray Accessories")]
        public ActionResult GracoTexsprayAccessories()
        {
            return View();
        }

        // GET: Graco-Texspray-Parts
        [Route("graco-texspray-parts")]
        [RouteName("Graco TexSpray Parts")]
        public ActionResult GracoTexsprayParts()
        {
            return View();
        }

        // GET: RotoFlex-II-RTX-650
        [Route("rotoflex-ii-rtx-650")]
        [RouteName("RotoFlex II Hose Replacement for RTX 650")]
        public ActionResult RotoFlex_II_RTX_650()
        {
            return View();
        }

        // GET: RotoFlex-RTX-750-1000
        [Route("rotoflex-rtx-750-1000")]
        [RouteName("RotoFlex Hose Replacement for RTX 750 and RTX 1000")]
        public ActionResult RotoFlex_RTX_750_1000()
        {
            return View();
        }

        // GET: texture-applcation
        [Route("texture-application")]
        [RouteName("Texture Application")]
        public ActionResult TextureApplication()
        {
            return View();
        }

        // GET: trouble-shooting.aspx
        [Route("trouble-shooting")]
        [RouteName("Trouble Shooting")]
        public ActionResult TroubleShooting()
        {
            return View();
        }
        // GET: trouble-shooting.aspx
        [Route("graco-powerfill-35-parts-breakdown")]
        [RouteName("Graco Powerfill 3.5 Parts Breakdown")]
        public ActionResult GracoPowerfill35PartsBreakdown()
        {
            return View();
        }
    }
}
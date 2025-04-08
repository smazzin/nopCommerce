using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("compressor/chicago-pneumatic")]
    public class ChicagoPneumaticController : Controller
    {
        [Route("")]
        [RouteName("Chicago Pneumatic")]
        public IActionResult Index()
        {
            return View();
        }


        // GET: AIRnet-Piping-System
        [Route("airnet-piping-System")]
        [RouteName("AIRnet Piping System")]
        public IActionResult AiRnetPipingSystem()
        {
            return View();
        }

        // GET: Dryers
        [Route("dryers")]
        [RouteName("Air Dryers")]
        public IActionResult Dryers()
        {
            return View();
        }

        // GET: Electric
        [Route("electric")]
        [RouteName("Electric Compressors")]
        public IActionResult Electric()
        {
            return View();
        }

        // GET: Filters
        [Route("filters")]
        [RouteName("Compressor Filters")]
        public IActionResult Filters()
        {
            return View();
        }

        // GET: Gas
        [Route("gas")]
        [RouteName("Gas Compressors")]
        public IActionResult Gas()
        {
            return View();
        }

        // GET: inline-air-filters-elements
        [Route("inline-air-filters-elements")]
        [RouteName("Inline Air Filters & Elements")]
        public IActionResult InlineAirFiltersElements()
        {
            return View();
        }

        // GET: Lubricants
        [Route("lubricants")]
        [RouteName("Compressor Lubricants")]
        public IActionResult Lubricants()
        {
            return View();
        }

        // GET: Rotary-Screw
        [Route("rotary-screw")]
        [RouteName("Rotary Screw Compressors")]
        public IActionResult RotaryScrew()
        {
            return View();
        }
    }
}
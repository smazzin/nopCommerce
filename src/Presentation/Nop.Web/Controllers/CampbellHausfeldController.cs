using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("compressor/campbell-hausfeld")]
    public class CampbellHausfeldController : Controller
    {
        // GET: Campbell_Hausfeld
        [Route("")]
        [RouteName("Campbell Hausfeld")]
        public IActionResult Index()
        {
            return View();
        }

        // GET: Campbell_Hausfeld
        [Route("campbell-portable")]
        [RouteName("Campbell Hausfeld Portable Air Compressors")]
        public IActionResult CampbellPortable()
        {
            return View();
        }
    }
}
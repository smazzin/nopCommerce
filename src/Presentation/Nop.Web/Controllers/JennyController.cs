using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("compressor/jenny")]
    public class JennyController : Controller
    {
        // GET: Jenny
        [Route("")]
        [RouteName("Jenny")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: hand-carry
        [Route("hand-carry")]
        [RouteName("Jenny Hand Carry Air Compressors")]
        public ActionResult HandCarry()
        {
            return View();
        }

        // GET: Stationary
        [Route("stationary")]
        [RouteName("Jenny Stationary Air Compressors")]
        public ActionResult Stationary()
        {
            return View();
        }

        // GET: Wheelbarrow
        [Route("wheelbarrow")]
        [RouteName("Jenny Wheelbarrow Air Compressors")]
        public ActionResult Wheelbarrow()
        {
            return View();
        }
    }
}
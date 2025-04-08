using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("compressor/rol-air")]
    public class RolAirController : Controller
    {
        // GET: Rol_Air
        [Route("")]
        [RouteName("Rol Air")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Electric-Wheelbarrow
        [Route("electric-wheelbarrow")]
        [RouteName("Rol Air Electric Wheelbarrow Air Compressors")]
        public ActionResult ElectricWheelbarrow()
        {
            return View();
        }

        // GET: Gas-Wheelbarrow
        [Route("gas-wheelbarrow")]
        [RouteName("Rol Air Gas Wheelbarrow Air Compressors")]
        public ActionResult GasWheelbarrow()
        {
            return View();
        }

        // GET: Hand-Carry
        [Route("hand-carry")]
        [RouteName("Rol Air Hand Carry Air Compressors")]
        public ActionResult HandCarry()
        {
            return View();
        }
    }
}
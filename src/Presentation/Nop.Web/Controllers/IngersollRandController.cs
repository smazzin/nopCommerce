using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("compressor/ingersoll-rand")]
    public class IngersollRandController : Controller
    {
        // GET: Ingersoll_Rand
        [Route("")]
        [RouteName("Ingersoll Rand")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dryers
        [Route("dryers")]
        [RouteName("Ingersoll Rand Air Dryers")]
        public ActionResult Dryers()
        {
            return View();
        }

        // GET: Electric-Reciprocating
        [Route("electric-reciprocating")]
        [RouteName("Electric Reciprocating Air Compressors")]
        public ActionResult ElectricReciprocating()
        {
            return View();
        }

        // GET: Filters
        [Route("filters")]
        [RouteName("Ingersoll Rand Air Compressor Filters")]
        public ActionResult Filters()
        {
            return View();
        }

        // GET: Gas-Reciprocating
        [Route("gas-reciprocating")]
        [RouteName("Gas Reciprocating Air Compressors")]
        public ActionResult GasReciprocating()
        {
            return View();
        }

        // GET: Lubricants
        [Route("lubricants")]
        [RouteName("Ingersoll Rand Air Compressor Lubricants")]
        public ActionResult Lubricants()
        {
            return View();
        }

        // GET: Piping
        [Route("piping")]
        [RouteName("Ingersoll Rand SimplAir Piping")]
        public ActionResult Piping()
        {
            return View();
        }

        // GET: Rotary-Screw
        [Route("rotary-screw")]
        [RouteName("Ingersoll Rand Rotary Screw Air Compressors")]
        public ActionResult RotaryScrew()
        {
            return View();
        }

        // GET: Variable-Speed
        [Route("variable-Speed")]
        [RouteName("Ingersoll Rand Variable Speed Air Compressors")]
        public ActionResult VariableSpeed()
        {
            return View();
        }
    }
}
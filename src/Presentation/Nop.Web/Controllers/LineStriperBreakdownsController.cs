using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("stripers/breakdowns")]
    public class LineStriperBreakdownsController : Controller
    {
        // GET: Line_Striper_Breakdowns
        [Route("")]
        [RouteName("Graco Linelazer Breakdowns")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: graco-parts-linelazer-3400-248861
        [Route("graco-parts-linelazer-3400-248861")]
        [RouteName("Graco Linelazer 3400 Parts Breakdown (248861)")]
        public ActionResult Graco_parts_linelazer_3400_248861()
        {
            return View();
        }

        // GET: graco-parts-linelazer-iv-3900-248863-248862
        [Route("graco-parts-linelazer-iv-3900-248863-248862")]
        [RouteName("Graco Linelazer IV 3900 Parts Breakdown (248863, 248862)")]
        public ActionResult Graco_parts_linelazer_iv_3900_248863_248862()
        {
            return View();
        }

        // GET: graco-parts-linelazer-iv-3900-5900
        [Route("graco-parts-linelazer-iv-3900-5900")]
        [RouteName("Graco Linelazer IV 3900/5900 Parts Breakdown")]
        public ActionResult Graco_parts_linelazer_iv_3900_5900()
        {
            return View();
        }
    }
}
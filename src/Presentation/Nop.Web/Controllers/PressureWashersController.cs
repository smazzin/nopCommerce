using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("washer")]
    public class PressureWashersController : Controller
    {
        // GET: washer
        [Route("")]
        [RouteName("Pressure Washers")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: accessories
        [Route("accessories")]
        [RouteName("Pressure Washer Accessories")]
        public ActionResult Accessories()
        {
            return View();
        }

        // GET: BE-Pressure-Supply
        [Route("be-pressure-supply")]
        [RouteName("BE Pressure Supply")]
        public ActionResult BePressureSupply()
        {
            return View();
        }

        // GET: compare-be-gas-pressure-washers
        [Route("compare-be-gas-pressure-washers")]
        [RouteName("Compare BE Gas Pressure Washers")]
        public ActionResult CompareBeGasPressureWashers()
        {
            return View();
        }

        // GET: compare-graco-gas-pressure-washers
        [Route("compare-graco-gas-pressure-washers")]
        [RouteName("Compare Graco Gas Pressure Washers")]
        public ActionResult CompareGracoGasPressureWashers()
        {
            return View();
        }

        // GET: FAQ
        [Route("faq")]
        [RouteName("Pressure Washer FAQ")]
        public ActionResult FAQ()
        {
            return View();
        }

        // GET: glossary
        [Route("glossary")]
        [RouteName("Pressure Washer Glossary")]
        public ActionResult Glossary()
        {
            return View();
        }

        // GET: Graco-pressure-washers-previous
        [Route("graco-pressure-washers-previous")]
        [RouteName("Past Graco Pressure Washers")]
        public ActionResult GracoPressureWashersPrevious()
        {
            return View();
        }

        // GET: Graco-pressure-washers
        [Route("graco-pressure-washers")]
        [RouteName("Graco Pressure Washers")]
        public ActionResult GracoPressureWashers()
        {
            return View();
        }

        // GET: High-Pressure-Hose-Repair
        [Route("high-pressure-hose-repair")]
        [RouteName("Hose Repair")]
        public ActionResult HighPressureHoseRepair()
        {
            return View();
        }

        // GET: maintenance
        [Route("maintenance")]
        [RouteName("Pressure Washer Maintenance")]
        public ActionResult Maintenance()
        {
            return View();
        }

        // GET: parts
        [Route("parts")]
        [RouteName("Pressure Washer Parts")]
        public ActionResult Parts()
        {
            return View();
        }

        // GET: pressure-nozzle-chart
        [Route("pressure-nozzle-chart")]
        [RouteName("Pressure Washer Nozzle Chart")]
        public ActionResult PressureNozzleChart()
        {
            return View();
        }

        // GET: Pressure-Washer-Tips
        [Route("pressure-washer-tips")]
        [RouteName("Pressure Washer Tip Guide")]
        public ActionResult PressureWasherTips()
        {
            return View();
        }

        // GET: storing
        [Route("storing")]
        [RouteName("Pressure Washer Storage")]
        public ActionResult Storing()
        {
            return View();
        }

        // GET: trouble-shooting
        [Route("trouble-shooting")]
        [RouteName("Pressure Washer Troubleshooting")]
        public ActionResult TroubleShooting()
        {
            return View();
        }

        // GET: wall-of-shame
        [Route("wall-of-shame")]
        [RouteName("Wall of Shame")]
        public ActionResult WallOfShame()
        {
            return View();
        }

        // GET: Whirl-A-Way
        [Route("whirl-a-way")]
        [RouteName("Whirl A Way")]
        public ActionResult WhirlAWay()
        {
            return View();
        }
    }
}
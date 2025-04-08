using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("airless/breakdowns")]
    public class AirlessBreakdownsController : Controller
    {
        
        // GET: breakdowns
        [Route("")]
        [RouteName("Graco Airless Sprayer Breakdowns")]
        public IActionResult Index()
        {
            return View();
        }

        // GET: Graco-parts-390-248800
        [Route("graco-parts-390-248800")]
        [RouteName("Graco 390 Stand Breakdown (248800)")]
        public IActionResult Graco_parts_390_248800()
        {
            return View();
        }

        // GET: Graco-parts-390-253958
        [Route("graco-parts-390-253958")]
        [RouteName("Graco 390 Stand Breakdown (253958)")]
        public IActionResult Graco_parts_390_253958()
        {
            return View();
        }

        // GET: Graco-parts-390-HiBoy-262019
        [Route("graco-parts-390-hiboy-262019")]
        [RouteName("Graco 390 Hi-Boy Breakdown (262019)")]
        public IActionResult Graco_parts_390_HiBoy_262019()
        {
            return View();
        }

        // GET: Graco-parts-390-pc-HiBoy-17C313
        [Route("graco-parts-390-pc-hiboy-17c313")]
        [RouteName("Graco 390 PC Hi-Boy Breakdown (17C313)")]
        public IActionResult Graco_parts_390_pc_HiBoy_17C313()
        {
            return View();
        }

        // GET: Graco-parts-390-pc-stand-17C310
        [Route("graco-parts-390-pc-stand-17c310")]
        [RouteName("Graco 390 PC Stand Breakdown (17C310)")]
        public IActionResult Graco_parts_390_pc_stand_17C310()
        {
            return View();
        }

        // GET: Graco-parts-395-pc-HiBoy-17C317
        [Route("graco-parts-395-pc-hiboy-17c317")]
        [RouteName("Graco 395 PC Hi-Boy Breakdown (17C317)")]
        public IActionResult Graco_parts_395_pc_HiBoy_17C317()
        {
            return View();
        }

        // GET: Graco-parts-395-pc-LoBoy-17C315
        [Route("graco-parts-395-pc-loboy-17c315")]
        [RouteName("Graco 395 PC Lo-Boy Breakdown (17C315)")]
        public IActionResult Graco_parts_395_pc_LoBoy_17C315()
        {
            return View();
        }

        // GET: Graco-parts-395-pc-stand-17C314
        [Route("graco-parts-395-pc-stand-17c314")]
        [RouteName("Graco 395 PC Stand Breakdown (17C314)")]
        public IActionResult Graco_parts_395_pc_stand_17C314()
        {
            return View();
        }

        // GET: Graco-parts-Ultra-395-495-595-Hi-Boy
        [Route("graco-parts-Ultra-395-495-595-Hi-Boy")]
        [RouteName("Graco Ultra 395, 495, 595 Hi-Boy Breakdown")]
        public IActionResult Graco_parts_Ultra_395_495_595_Hi_Boy()
        {
            return View();
        }

        // GET: Graco-parts-Ultra-395-495-595-Lo-Boy
        [Route("graco-parts-ultra-395-495-595-lo-boy")]
        [RouteName("Graco Ultra 395, 495, 595 Lo-Boy Breakdown")]
        public IActionResult Graco_parts_Ultra_395_495_595_Lo_Boy()
        {
            return View();
        }

        // GET: Graco-parts-Ultra-395-495-stand
        [Route("graco-parts-ultra-395-495-stand")]
        [RouteName("Graco Ultra 395, 495 Stand Breakdown")]
        public IActionResult Graco_parts_Ultra_395_495_stand()
        {
            return View();
        }

        // GET: Graco-parts-Ultra-Max-II-490-495-595-Hi-Boy
        [Route("graco-parts-ultra-max-ii-490-495-595-hi-boy")]
        [RouteName("Graco Ultra Max II 490, 495, 595 Hi-Boy Breakdown")]
        public IActionResult Graco_parts_Ultra_Max_II_490_495_595_Hi_Boy()
        {
            return View();
        }

        // GET: Graco-parts-Ultra-Max-II-490-495-595-Lo-Boy
        [Route("graco-parts-ultra-Max-ii-490-495-595-lo-boy")]
        [RouteName("Graco Ultra Max II 490, 495, 595 Lo-Boy Breakdown")]
        public IActionResult Graco_parts_Ultra_Max_II_490_495_595_Lo_Boy()
        {
            return View();
        }

        // GET: Graco-parts-ultra-max-II-490-495-595-pc-pro-hi-boy
        [Route("graco-parts-ultra-max-ii-490-495-595-pc-pro-hi-boy")]
        [RouteName("Graco Ultra Max II 490, 495, 595 PC Pro Hi-Boy Breakdown")]
        public IActionResult Graco_parts_ultra_max_II_490_495_595_pc_pro_hi_boy()
        {
            return View();
        }

        // GET: Graco-parts-ultra-max-II-490-495-595-pc-pro-Lo-Boy
        [Route("graco-parts-ultra-max-ii-490-495-595-pc-pro-lo-boy")]
        [RouteName("Graco Ultra Max II 490, 495, 595 PC Pro Lo-Boy Breakdown")]
        public IActionResult Graco_parts_ultra_max_II_490_495_595_pc_pro_Lo_Boy()
        {
            return View();
        }

        // GET: Graco-parts-ultra-max-ii-490-495-pc-pro-stand
        [Route("graco-parts-ultra-max-ii-490-495-pc-pro-stand")]
        [RouteName("Graco Ultra Max II 490, 495 PC Pro Stand Breakdown")]
        public IActionResult Graco_parts_ultra_max_II_490_495_pc_pro_stand()
        {
            return View();
        }

        // GET: Graco-parts-Ultra-Max-ii-490-495-stand
        [Route("graco-parts-ultra-max-ii-490-495-stand")]
        [RouteName("Graco Ultra Max II 490, 495 Stand Breakdown")]
        public IActionResult Graco_parts_Ultra_Max_II_490_495_stand()
        {
            return View();
        }

        // GET: Graco-ST-parts-234127
        [Route("graco-st-parts-234127")]
        [RouteName("Graco ST Breakdown (234127)")]
        public IActionResult Graco_ST_parts_234127()
        {
            return View();
        }

        // GET: Graco-stx-parts-234126
        [Route("graco-stx-parts-234126")]
        [RouteName("Graco STX Breakdown (234126)")]
        public IActionResult Graco_STX_parts_234126()
        {
            return View();
        }

    }

}
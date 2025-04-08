using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("compressor")]
    public class CompressorController : Controller
    {
        // GET: compressor
        [Route("")]
        [RouteName("Air Compressors")]
        public IActionResult Index()
        {
            return View();
        }

        // GET: wall-of-shame
        [Route("wall-of-shame")]
        [RouteName("Wall of Shame")]
        public IActionResult WallOfShame()
        {
            return View();
        }

        // GET: trouble-shooting
        [Route("trouble-shooting")]
        [RouteName("Air Compressor Troubleshooting")]
        public IActionResult TroubleShooting()
        {
            return View();
        }

        // GET: safety
        [Route("safety")]
        [RouteName("Air Compressor Safety")]
        public IActionResult Safety()
        {
            return View();
        }

        // GET: maintenance
        [Route("maintenance")]
        [RouteName("Air Compressor Maintenance")]
        public IActionResult Maintenance()
        {
            return View();
        }

        // GET: Jenny_Handcarry
        // [Route("compressor/Jenny_Handcarry")]
        // public IActionResult Jenny_Handcarry()
        // {
        //    return View();
        //}

        // GET: glossary
        [Route("glossary")]
        [RouteName("Air Compressor Glossary")]
        public IActionResult Glossary()
        {
            return View();
        }

        // GET: faq
        [Route("faq")]
        [RouteName("Air Compressor FAQ")]
        public IActionResult Faq()
        {
            return View();
        }

        // GET: couplers-and-fittings
        [Route("couplers-and-fittings")]
        [RouteName("Air Compressor Couplers and Fittings")]
        public IActionResult CouplersAndFittings()
        {
            return View();
        }

        // GET: Compressor-Service
        [Route("compressor-service")]
        [RouteName("Air Compressor Service")]
        public IActionResult CompressorService()
        {
            return View();
        }

        // GET: air-shop
        [Route("air-shop")]
        [RouteName("Air Shop")]
        public IActionResult AirShop()
        {
            return View();
        }

        // GET: air-contractor
        [Route("air-contractor")]
        [RouteName("Contractor Air Compressors")]
        public IActionResult AirContractor()
        {
            return View();
        }

        // GET: air-industrial
        [Route("air-industrial")]
        [RouteName("Industrial Air Compressors")]
        public IActionResult AirIndustrial()
        {
            return View();
        }

        // GET: air-compressor-parts
        [Route("air-compressor-parts")]
        [RouteName("Air Compressor Parts")]
        public IActionResult AirCompressorParts()
        {
            return View();
        }

        // GET: air-compressor-anatomy
        [Route("air-compressor-anatomy")]
        [RouteName("Air Compressor Anatomy")]
        public IActionResult AirCompressorAnatomy()
        {
            return View();
        }

        // GET: Accessories
        [Route("accessories")]
        [RouteName("Air Compressor Accessories")]
        public IActionResult Accessories()
        {
            return View();
        }


    }
}
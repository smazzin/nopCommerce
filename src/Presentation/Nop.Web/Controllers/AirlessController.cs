using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    [Route("airless")]
    public class AirlessController : Controller
    {
        [Route("")]
        [RouteName("Airless")]
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


        // GET: using-pump-preserver
        [Route("using-pump-preserver")]
        [RouteName("Using Pump Preserver")]
        public IActionResult UsingPumpPreserver()
        {
            return View();
        }

        // GET: TrueCoat-Sprayers-archive
        [Route("trueCoat-sprayers-archive")]
        [RouteName("TrueCoat Sprayers Archive")]
        public IActionResult TrueCoatSprayersArchive()
        {
            return View();
        }

        // GET: trouble-shooting
        [Route("trouble-shooting")]
        [RouteName("Airless Troubleshooting")]
        public IActionResult TroubleShooting()
        {
            return View();
        }

        // get: tips-on-tips
        [Route("tips-on-tips")]
        [RouteName("Tips on Tips")]
        public IActionResult TipsOnTips()
        {
            return View();
        }

        // get: tip-sizing
        [Route("tip-sizing")]
        [RouteName("Airless Tip Sizing")]
        public IActionResult TipSizing()
        {
            return View();
        }

        // get: tip-sizes
        [Route("tip-sizes")]
        [RouteName("Tip Sizes")]
        public IActionResult TipSizes()
        {
            return View();
        }

        // get: surface-prep
        [Route("surface-prep")]
        [RouteName("Surface Prep")]
        public IActionResult SurfacePrep()
        {
            return View();
        }

        // get: storage
        [Route("storage")]
        [RouteName("Storing Your Sprayer")]
        public IActionResult Storage()
        {
            return View();
        }

        // get: spraying-techniques
        [Route("spraying-techniques")]
        [RouteName("Spraying Techniques")]
        public IActionResult SprayingTechniques()
        {
            return View();
        }

        // get: sprayer-pumps
        [Route("sprayer-pumps")]
        [RouteName("Airless Sprayer Pumps")]
        public IActionResult SprayerPumps()
        {
            return View();
        }

        // get: sprayer-guns
        [Route("sprayer-guns")]
        [RouteName("Airless Spray Gun Parts")]
        public IActionResult SprayerGuns()
        {
            return View();
        }

        // get: sprayer-anatomy
        [Route("sprayer-anatomy")]
        [RouteName("Airless Sprayer Anatomy")]
        public IActionResult SprayerAnatomy()
        {
            return View();
        }

        // get: safety
        [Route("safety")]
        [RouteName("Safety")]
        public IActionResult Safety()
        {
            return View();
        }

        // get: repair
        [Route("repair")]
        [RouteName("Repair")]
        public IActionResult Repair()
        {
            return View();
        }

        // get: rac-x-tips
        [Route("rac-x-tips")]
        [RouteName("RAC X Tips")]
        public IActionResult RacXTips()
        {
            return View();
        }

        // get: other-graco-sprayer
        [Route("other-graco-sprayer")]
        [RouteName("Other Graco Sprayer")]
        public IActionResult OtherGracoSprayer()
        {
            return View();
        }

        // get: maintenance
        [Route("maintenance")]
        [RouteName("Airless Sprayer Maintenance")]
        public IActionResult Maintenance()
        {
            return View();
        }

        // get: magnum-spray-guns
        [Route("magnum-spray-guns")]
        [RouteName("Magnum Spray Guns")]
        public IActionResult MagnumSprayGuns()
        {
            return View();
        }

        // get: magnum-parts
        [Route("magnum-parts")]
        [RouteName("Graco Magnum Airless Parts")]
        public IActionResult MagnumParts()
        {
            return View();
        }

        // get: magnum-lacquer-kit
        [Route("magnum-lacquer-kit")]
        [RouteName("Graco Magnum Lacquer Kit")]
        public IActionResult MagnumLacquerKit()
        {
            return View();
        }

        // get: magnum-cross-reference
        [Route("magnum-cross-reference")]
        [RouteName("Graco Magnum Cross Reference")]
        public IActionResult MagnumCrossReference()
        {
            return View();
        }

        // get: magnum-accessories
        [Route("magnum-accessories")]
        [RouteName("Graco Magnum Accessories")]
        public IActionResult MagnumAccessories()
        {
            return View();
        }

        // get: graco-xtreme-sprayers
        [Route("graco-xtreme-sprayers")]
        [RouteName("Graco Xtreme Sprayers")]
        public IActionResult GracoXtremeSprayers()
        {
            return View();
        }

        // get: graco-truecoat-pro-ii-sprayer-parts
        [Route("graco-truecoat-pro-ii-sprayer-parts")]
        [RouteName("Graco TrueCoat Pro II Sprayer Parts")]
        public IActionResult GracoTrueCoatProIISprayerParts()
        {
            return View();
        }

        // get: graco-truecoat-pro-ii-cordless-sprayer
        [Route("graco-truecoat-pro-ii-cordless-sprayer")]
        [RouteName("TrueCoat Pro II Cordless Sprayer")]
        public IActionResult GracoTrueCoatProIICordlessSprayer()
        {
            return View();
        }

        // get: graco-truecoat-pro-finefinish-sprayer-parts
        [Route("graco-truecoat-pro-finefinish-sprayer-parts")]
        [RouteName("Graco TrueCoat Pro Fine Finish Sprayer Parts")]
        public IActionResult GracoTrueCoatProFineFinishSprayerParts()
        {
            return View();
        }

        // get: graco-truecoat-pro-cordless-sprayer
        [Route("graco-truecoat-pro-cordless-sprayer")]
        [RouteName("TrueCoat Pro Cordless Sprayer")]
        public IActionResult GracoTrueCoatProCordlessSprayer()
        {
            return View();
        }

        // get: graco-truecoat-pro-accessories
        [Route("graco-truecoat-pro-accessories")]
        [RouteName("Graco TrueCoat Pro Accessories")]
        public IActionResult GracoTrueCoatProAccessories()
        {
            return View();
        }

        // get: graco-truecoat-ii-electric-parts
        [Route("graco-truecoat-ii-electric-parts")]
        [RouteName("Graco TrueCoat II Electric Parts")]
        public IActionResult GracoTrueCoatIIElectricParts()
        {
            return View();
        }

        // get: graco-truecoat-handheld-airless-sprayers
        [Route("graco-truecoat-handheld-airless-sprayers")]
        [RouteName("Graco TrueCoat Handheld Airless Sprayers")]
        public IActionResult GracoTrueCoatHandheldAirlessSprayers()
        {
            return View();
        }

        // get: graco-sprayer-parts-gas-prior
        [Route("graco-sprayer-parts-gas-prior")]
        [RouteName("Past Gas Airless Graco Sprayer Parts")]
        public IActionResult GracoSprayerPartsGasPrior()
        {
            return View();
        }

        // get: graco-sprayer-parts-electric-prior
        [Route("graco-sprayer-parts-electric-prior")]
        [RouteName("Past Electric Airless Graco Sprayer Parts")]
        public IActionResult GracoSprayerPartsElectricPrior()
        {
            return View();
        }

        // get: graco-series-sprayers
        [Route("graco-series-sprayers")]
        [RouteName("Graco Series Sprayers")]
        public IActionResult GracoSeriesSprayers()
        {
            return View();
        }

        // get: graco-promotions
        [Route("graco-promotions")]
        [RouteName("Graco Promotions")]
        public IActionResult GracoPromotions()
        {
            return View();
        }

        // get: graco-promotions-past
        [Route("graco-promotions-past")]
        [RouteName("Past Graco Promotions")]
        public IActionResult GracoPromotionsPast()
        {
            return View();
        }

        // get: graco-parts
        [Route("graco-parts")]
        [RouteName("Electric Airless Graco Sprayer Parts")]
        public IActionResult GracoParts()
        {
            return View();
        }

        // get: graco-parts-misc
        [Route("graco-parts-misc")]
        [RouteName("Miscellaneous Graco Parts")]
        public IActionResult GracoPartsMisc()
        {
            return View();
        }

        // get: graco-parts-gas
        [Route("graco-parts-gas")]
        [RouteName("Gas Airless Graco Sprayer Parts")]
        public IActionResult GracoPartsGas()
        {
            return View();
        }

        // get: graco-magnum
        [Route("graco-magnum")]
        [RouteName("Graco Magnum Sprayers")]
        public IActionResult GracoMagnum()
        {
            return View();
        }

        // get: graco-finishpro-parts-accessories
        [Route("graco-finishpro-parts-accessories")]
        [RouteName("Graco FinishPro Parts & Accessories")]
        public IActionResult GracoFinishProPartsAccessories()
        {
            return View();
        }

        // get: graco-endurance-now
        [Route("graco-endurance-now")]
        [RouteName("Graco Endurance Now")]
        public IActionResult GracoEnduranceNow()
        {
            return View();
        }

        // get: graco-endurance-advantage
        [Route("graco-endurance-advantage")]
        [RouteName("Graco Endurance Advantage")]
        public IActionResult GracoEnduranceAdvantage()
        {
            return View();
        }

        // get: graco-cross-reference
        [Route("graco-cross-reference")]
        [RouteName("Graco Cross Reference")]
        public IActionResult GracoCrossReference()
        {
            return View();
        }

        // get: graco-big-rig-parts
        [Route("graco-big-rig-parts")]
        [RouteName("Graco Big Rig Parts")]
        public IActionResult GracoBigRigParts()
        {
            return View();
        }

        // get: graco-190es
        [Route("graco-190es")]
        [RouteName("Graco 190ES")]
        public IActionResult Graco190Es()
        {
            return View();
        }

        // get: glossary
        [Route("glossary")]
        [RouteName("Airless Sprayer Glossary")]
        public IActionResult Glossary()
        {
            return View();
        }

        // get: gift-ideas
        [Route("gift-ideas")]
        [RouteName("Gift Ideas")]
        public IActionResult GiftIdeas()
        {
            return View();
        }

        // get: faq
        [Route("faq")]
        [RouteName("Airless Sprayer FAQ")]
        public IActionResult Faq()
        {
            return View();
        }

        // get: discontinued-graco
        [Route("discontinued-graco")]
        [RouteName("Discontinued Graco Sprayers")]
        public IActionResult DiscontinuedGraco()
        {
            return View();
        }

        // get: compare-truecoat-sprayers
        [Route("compare-truecoat-sprayers")]
        [RouteName("Compare TrueCoat Sprayers")]
        public IActionResult CompareTrueCoatSprayers()
        {
            return View();
        }

        // get: compare-truecoat-ii-sprayers
        [Route("compare-truecoat-ii-sprayers")]
        [RouteName("Compare TrueCoat II Sprayers")]
        public IActionResult CompareTrueCoatIiSprayers()
        {
            return View();
        }

        // get: compare-graco-ultra-handheld-sprayers
        [Route("compare-graco-ultra-handheld-sprayers")]
        [RouteName("Compare Graco Ultra Handheld Sprayers")]
        public IActionResult CompareGracoUltraHandheldSprayers()
        {
            return View();
        }

        // get: compare-magnum-sprayers
        [Route("compare-magnum-sprayers")]
        [RouteName("Compare Graco Magnum Sprayers")]
        public IActionResult compare_Magnum_sprayers()
        {
            return View();
        }

        // get: compare-magnum-sprayers-archive
        [Route("compare-magnum-sprayers-archive")]
        [RouteName("Compare Past Graco Magnum Sprayers")]
        public IActionResult CompareMagnumSprayersArchive()
        {
            return View();
        }

        // get: compare-graco-gh-big-rig-sprayers
        [Route("compare-graco-gh-big-rig-sprayers")]
        [RouteName("Compare Graco GH Big Rig Sprayers")]
        public IActionResult CompareGracoGhBigRigSprayers()
        {
            return View();
        }

        // get: compare-contractor-sprayers
        [Route("compare-contractor-sprayers")]
        [RouteName("Compare Electric Contractor Airless Sprayers")]
        public IActionResult Compare_Contractor_Sprayers()
        {
            return View();
        }

        // get: compare-contractor-sprayers-gas
        [Route("compare-contractor-sprayers-gas")]
        [RouteName("Compare Gas Contractor Airless Sprayers")]
        public IActionResult CompareContractorSprayersGas()
        {
            return View();
        }

        // get: compare-contractor-sprayers-gas-archive
        [Route("compare-contractor-sprayers-gas-archive")]
        [RouteName("Compare Past Gas Contractor Airless Sprayers")]
        public IActionResult CompareContractorSprayersGasArchive()
        {
            return View();
        }

        // get: compare-contractor-sprayers-archive
        [Route("compare-contractor-sprayers-archive")]
        [RouteName("Compare Past Electric Contractor Airless Sprayers")]
        public IActionResult CompareContractorSprayersArchive()
        {
            return View();
        }

        // get: cleaning
        [Route("cleaning")]
        [RouteName("Airless Sprayer Cleaning")]
        public IActionResult Cleaning()
        {
            return View();
        }

        // get: cleaning-magnum
        [Route("cleaning-magnum")]
        [RouteName("Cleaning Graco Magnum Sprayers")]
        public IActionResult CleaningMagnum()
        {
            return View();
        }

        // get: airlessco-gas-sprayers
        [Route("airlessco-gas-sprayers")]
        [RouteName("Airlessco Gas Sprayers")]
        public IActionResult AirlesscoGasSprayers()
        {
            return View();
        }

        // get: airlessco-electric-sprayers
        [Route("airlessco-electric-sprayers")]
        [RouteName("Airlessco Electric Sprayers")]
        public IActionResult AirlesscoElectricSprayers()
        {
            return View();
        }

        // get: accessories
        [Route("accessories")]
        [RouteName("Airless Sprayer Accessories")]
        public IActionResult Accessories()
        {
            return View();

        }

        // get: 55-gallon-drum-chart
        [Route("55-gallon-drum-chart")]
        [RouteName("55 Gallon Drum Chart")]
        public IActionResult DrumChart()
        {
            return View();
        }
    }
}
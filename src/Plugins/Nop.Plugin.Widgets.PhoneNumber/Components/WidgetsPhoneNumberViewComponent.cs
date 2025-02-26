using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Services.Configuration;
using Nop.Web.Framework.Components;

using Nop.Services.Catalog;

namespace Nop.Plugin.Widgets.PhoneNumber.Components
{

    [ViewComponent(Name = "WidgetsPhoneNumber")]
    public class WidgetsPhoneNumberViewComponent : NopViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly IStaticCacheManager _cacheManager;
        private readonly ISettingService _settingService;
        private readonly ICategoryService _categoryService;
        private readonly Web.Factories.ICatalogModelFactory _catalogModelFactory;


        public WidgetsPhoneNumberViewComponent
        (
            IStoreContext storeContext,
            IStaticCacheManager cacheManager,
            ISettingService settingService,
            ICategoryService categoryService,
            Web.Factories.ICatalogModelFactory catalogModelFactory
        )

        {
            _storeContext = storeContext;
            _cacheManager = cacheManager;
            _settingService = settingService;
            _categoryService = categoryService;
            _catalogModelFactory = catalogModelFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, int currentCategoryId, int currentProductId)
        {
            var model = await _catalogModelFactory.PrepareCategoryNavigationModelAsync(currentCategoryId, currentProductId);
            return View("~/Plugins/Widgets.PhoneNumber/Views/PublicInfo.cshtml", model);
        }

    }

}

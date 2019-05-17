using System;
using System.Threading.Tasks;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Interfaces.Repositories;
using GoodsStore.Core.Interfaces.Specifications;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Controllers
{
    public class GoodsController : Controller
    {
        private readonly ICatalogItemRepository _catalogItemsRepository;
        private readonly Func<ISpecification<CatalogItem>> _catalogItemSelectionSpecificationFactory;
        private readonly ICatalogItemFactory _catalogItemFactory;

        public GoodsController(ICatalogItemRepository catalogItemsRepository, 
            Func<ISpecification<CatalogItem>> catalogItemSelectionSpecificationFactory,
            ICatalogItemFactory catalogItemFactory)
        {
            _catalogItemsRepository = catalogItemsRepository;
            _catalogItemSelectionSpecificationFactory = catalogItemSelectionSpecificationFactory;
            _catalogItemFactory = catalogItemFactory;
        }
        // GET
        public async Task<IActionResult> Index(int productTypeId)
        {
            var specification = _catalogItemSelectionSpecificationFactory.Invoke();
            specification.ConfigyreSpecificaton(ci => ci.ItemTypeId == productTypeId, 0, 6);
            var catalogItems = await _catalogItemsRepository.ListIncludesItemTypeAndBrand(specification);
            var res = _catalogItemFactory.GetCategoryItemModels(catalogItems);
            return View(res);
        }
    }
}
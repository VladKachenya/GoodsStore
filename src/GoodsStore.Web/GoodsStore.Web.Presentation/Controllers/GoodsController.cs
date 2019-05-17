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
        private readonly IAsyncRepository<CatalogItem> _catalogItemsRepository;
        private readonly Func<ISpecification<CatalogItem>> _catalogItemSelectionSpecificationFactory;
        private readonly ICatalogItemFactory _catalogItemFactory;

        public GoodsController(IAsyncRepository<CatalogItem> catalogItemsRepository, 
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
            specification.ConfigyreSpecificaton(ci => ci.ItemTypeId == productTypeId);
            var catalogItems = await _catalogItemsRepository.ListAsync(specification);
            var res = _catalogItemFactory.GetCategoryItemModels(catalogItems);
            return View(res);
        }
    }
}
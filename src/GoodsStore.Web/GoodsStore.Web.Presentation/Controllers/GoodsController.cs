using System;
using System.Threading.Tasks;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Core.Interfaces.Repositories;
using GoodsStore.Core.Interfaces.Specifications;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Controllers
{
    public class GoodsController : Controller
    {
        private readonly ICatalogItemRepository _catalogItemsRepository;
        private readonly IRepository<ItemType> _itemTypeRepository;
        private readonly Func<ISpecification<CatalogItem>> _catalogItemSelectionSpecificationFactory;
        private readonly ICatalogItemFactory _catalogItemFactory;
        private readonly IGoodsIndexModelBuilder _goodsIndexModelBuilder;

        public GoodsController(
            ICatalogItemRepository catalogItemsRepository, 
            IRepository<ItemType> itemTypeRepository,
            Func<ISpecification<CatalogItem>> catalogItemSelectionSpecificationFactory,
            ICatalogItemFactory catalogItemFactory,
            IGoodsIndexModelBuilder goodsIndexModelBuilder)
        {
            _catalogItemsRepository = catalogItemsRepository;
            _itemTypeRepository = itemTypeRepository;
            _catalogItemSelectionSpecificationFactory = catalogItemSelectionSpecificationFactory;
            _catalogItemFactory = catalogItemFactory;
            _goodsIndexModelBuilder = goodsIndexModelBuilder;
        }
        // GET
        public async Task<IActionResult> Index(int productTypeId)
        {
            var specification = _catalogItemSelectionSpecificationFactory.Invoke();
            specification.ConfigyreSpecificaton(ci => ci.ItemTypeId == productTypeId, 0, 6);
            var catalogItems = await _catalogItemsRepository.ListIncludesItemTypeAndBrand(specification);
            var itemsType = await _itemTypeRepository.GetById(productTypeId);
            var data = await _goodsIndexModelBuilder.BuildGoodsIndexModel(itemsType.Name, catalogItems);
            var res = _catalogItemFactory.GetCategoryItemModels(catalogItems);
            return View(res);
        }
    }
}
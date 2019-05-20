using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Interfaces.Repositories;
using GoodsStore.Core.Domain.Interfaces.Specifications;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsStore.Web.Presentation.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IRepository<CatalogItem> _catalogItemsRepository;
        private readonly IRepository<ItemType> _itemTypeRepository;
        private readonly Func<ISpecification<CatalogItem>> _catalogItemSelectionSpecificationFactory;
        private readonly IGoodsIndexModelFactory _goodsIndexModelFactory;

        public GoodsController(
            ICatalogItemRepository catalogItemsRepository,
            IRepository<ItemType> itemTypeRepository,
            Func<ISpecification<CatalogItem>> catalogItemSelectionSpecificationFactory,
            IGoodsIndexModelFactory goodsIndexModelFactory)
        {
            _catalogItemsRepository = catalogItemsRepository;
            _itemTypeRepository = itemTypeRepository;
            _catalogItemSelectionSpecificationFactory = catalogItemSelectionSpecificationFactory;
            _goodsIndexModelFactory = goodsIndexModelFactory;
        }
        // GET
        public async Task<IActionResult> Index(int productTypeId)
        {
            var specification = _catalogItemSelectionSpecificationFactory.Invoke();
            specification.ConfigyreSpecificaton(ci => ci.ItemTypeId == productTypeId).ApplyPaging(0, 6);
            var catalogItems = await _catalogItemsRepository.List(specification);
            var itemsType = await _itemTypeRepository.GetById(productTypeId);
            var data = _goodsIndexModelFactory.BuildGoodsIndexModel(itemsType, catalogItems);
            return View(data);
        }
    }
}
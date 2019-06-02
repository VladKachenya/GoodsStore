using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;

namespace GoodsStore.Web.Presentation.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IRepository<CatalogItem> _catalogItemsRepository;
        private readonly IRepository<ItemType> _itemTypeRepository;
        private readonly Func<ISpecification<CatalogItem>> _catalogItemSelectionSpecificationFactory;
        private readonly IGoodsIndexModelFactory _goodsIndexModelFactory;

        public GoodsController(
            IRepository<CatalogItem> catalogItemsRepository,
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
        public async Task<IActionResult> Index(int goodsTypeId)
        {
            var specification = _catalogItemSelectionSpecificationFactory.Invoke();
            specification.ConfigyreSpecificaton(ci => ci.ItemTypeId == goodsTypeId).ApplyPaging(0, 6);
            var catalogItems = await _catalogItemsRepository.List(specification);
            var itemsType = await _itemTypeRepository.GetById(goodsTypeId);
            var data = _goodsIndexModelFactory.BuildGoodsIndexModel(itemsType, catalogItems);
            return View(data);
        }

        public async Task<IActionResult> Item(string typeDiscriminator, int id)
        {
            return View();
        }
    }
}
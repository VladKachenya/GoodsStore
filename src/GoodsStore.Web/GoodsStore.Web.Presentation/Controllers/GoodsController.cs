using Autofac;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Helpers;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GoodsStore.Web.Presentation.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IRepository<CatalogItem> _catalogItemsRepository;
        private readonly IRepository<ItemType> _itemTypeRepository;
        private readonly Func<ISpecification<CatalogItem>> _catalogItemSpecificationFactory;
        private readonly Func<ISpecification<ItemType>> _itemTypeSpecificationFactory;
        private readonly IGoodsIndexModelFactory _goodsIndexModelFactory;
        private readonly CatalogItemTypeDictionary _catalogItemTypeDictionary;
        private readonly ICatalogItemModelFactory _catalogItemModelFactory;
        private readonly IContainer _container;

        public GoodsController(
            IRepository<CatalogItem> catalogItemsRepository,
            IRepository<ItemType> itemTypeRepository,
            Func<ISpecification<CatalogItem>> catalogItemSpecificationFactory,
            Func<ISpecification<ItemType>> itemTypeSpecificationFactory,
            IGoodsIndexModelFactory goodsIndexModelFactory,
            CatalogItemTypeDictionary catalogItemTypeDictionary,
            ICatalogItemModelFactory catalogItemModelFactory,
            IContainer container)
        {
            _catalogItemsRepository = catalogItemsRepository;
            _itemTypeRepository = itemTypeRepository;
            _catalogItemSpecificationFactory = catalogItemSpecificationFactory;
            _itemTypeSpecificationFactory = itemTypeSpecificationFactory;
            _goodsIndexModelFactory = goodsIndexModelFactory;
            _catalogItemTypeDictionary = catalogItemTypeDictionary;
            _catalogItemModelFactory = catalogItemModelFactory;
            _container = container;
        }

        public async Task<IActionResult> Index(string typeDiscriminator)
        {
            var spec = _itemTypeSpecificationFactory().ConfigyreSpecificaton(it => it.UnitName == typeDiscriminator);
            var itemsType = await _itemTypeRepository.GetFirstOrDefault(spec);
            var data = _goodsIndexModelFactory.BuildGoodsIndexModel(itemsType);
            return View(data);
        }

        public async Task<IActionResult> Item(string typeDiscriminator, int id)
        {
            var catalogItemType = _catalogItemTypeDictionary.GetCatalogItemType(typeDiscriminator);

            var catalogItemReposity = _container.Resolve(typeof(ICatalogItemRepository<>).MakeGenericType(catalogItemType)) as ICatalogItemRepository;
            var catalogItem = await catalogItemReposity.GetById(id);

            var data = _catalogItemModelFactory.GetCatalogItemModel(catalogItem);

            return View(data);
        }
    }
}
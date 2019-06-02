using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using GoodsStore.Core.Domain.Helpers;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Web.Framework.Interfaces.Factories;

namespace GoodsStore.Web.Presentation.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IRepository<CatalogItem> _catalogItemsRepository;
        private readonly IRepository<ItemType> _itemTypeRepository;
        private readonly Func<ISpecification<CatalogItem>> _catalogItemSelectionSpecificationFactory;
        private readonly IGoodsIndexModelFactory _goodsIndexModelFactory;
        private readonly IGeneratorsDictionary<ITableItemsGenerator> _generatorsDictionary;
        private readonly CatalogItemTypeDictionary _catalogItemTypeDictionary;
        private readonly IContainer _container;

        public GoodsController(
            IRepository<CatalogItem> catalogItemsRepository,
            IRepository<ItemType> itemTypeRepository,
            Func<ISpecification<CatalogItem>> catalogItemSelectionSpecificationFactory,
            IGoodsIndexModelFactory goodsIndexModelFactory,
            IGeneratorsDictionary<ITableItemsGenerator> generatorsDictionary,
            CatalogItemTypeDictionary catalogItemTypeDictionary,
            IContainer container)
        {
            _catalogItemsRepository = catalogItemsRepository;
            _itemTypeRepository = itemTypeRepository;
            _catalogItemSelectionSpecificationFactory = catalogItemSelectionSpecificationFactory;
            _goodsIndexModelFactory = goodsIndexModelFactory;
            _generatorsDictionary = generatorsDictionary;
            _catalogItemTypeDictionary = catalogItemTypeDictionary;
            _container = container;
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
            var catalogItemType = _catalogItemTypeDictionary.GetCatalogItemType(typeDiscriminator);

            var catalogItemReposity = _container.Resolve(typeof(ICatalogItemRepository<>).MakeGenericType(catalogItemType)) as ICatalogItemRepository;
            var catalogItem = await catalogItemReposity.GetById(id);

            var table = _generatorsDictionary.GetGenerator(typeDiscriminator).GetItems(catalogItem);

            return View(table);
        }
    }
}
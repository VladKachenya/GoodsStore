using Autofac;
using GoodsStore.Core.Domain.Helpers;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Core.Logic.Interfases.Filter;
using GoodsStore.Core.Logic.Interfases.Hepers;
using GoodsStore.Web.Framework.Controllers;
using GoodsStore.Web.ViewModel.Interfaces.Converters;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Models.CompositModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GoodsStore.Web.Presentation.Controllers.ApiControllers
{
    public class CatalogController : BaseApiController
    {
        private readonly ICatalogItemModelFactory _catalogItemModelFactory;
        private readonly IContainer _container;
        private readonly IModelFilterToPredictionConverter _modelFilterToPredictionConverter;
        private readonly IFilterConfigurator _filterConfigurator;
        private readonly IPropertyNameValidator _propertyNameValidator;
        private readonly CatalogItemTypeDictionary _catalogItemTypeDictionary;


        public CatalogController(
            ICatalogItemModelFactory catalogItemModelFactory,
            CatalogItemTypeDictionary catalogItemTypeDictionary,
            IContainer container,
            IModelFilterToPredictionConverter modelFilterToPredictionConverter,
            IFilterConfigurator filterConfigurator,
            IPropertyNameValidator propertyNameValidator
            )
        {
            _catalogItemModelFactory = catalogItemModelFactory;
            _modelFilterToPredictionConverter = modelFilterToPredictionConverter;
            _filterConfigurator = filterConfigurator;
            _propertyNameValidator = propertyNameValidator;
            _catalogItemTypeDictionary = catalogItemTypeDictionary;
            _container = container;

        }


        //Refrigerator
        [HttpGet("{typeDiscriminator}")]
        public async Task<ActionResult> CatalogItems(string typeDiscriminator)
        {
            // getting type of catalog item
            Type catalogItemType;
            try
            {
                catalogItemType = _catalogItemTypeDictionary.GetCatalogItemType(typeDiscriminator);
            }
            catch (Exception e)
            {
                //return Json(null);
                return NotFound();
            }

            // configyre specification
            var filtringSpecification = _container.Resolve(typeof(ICatalogItemFiltringSpecification<>).MakeGenericType(catalogItemType)) as ICatalogItemFiltringSpecification;

            filtringSpecification.ApplyPaging(0, 6);

            var catalogItemReposity = _container.Resolve(typeof(ICatalogItemRepository<>).MakeGenericType(catalogItemType)) as ICatalogItemRepository;

            var res = _catalogItemModelFactory.GetCatalogItemShortModels(await catalogItemReposity.List(filtringSpecification));
            return Ok(res);
        }

        [HttpGet("{typeDiscriminator}")]
        public async Task<IActionResult> Count(string typeDiscriminator)
        {
            // getting type of catalog item
            Type catalogItemType;
            try
            {
                catalogItemType = _catalogItemTypeDictionary.GetCatalogItemType(typeDiscriminator);
            }
            catch (Exception e)
            {
                //return Json(null);
                return NotFound();
            }

            // configyre specification
            var filtringSpecification = _container.Resolve(typeof(ICatalogItemFiltringSpecification<>).MakeGenericType(catalogItemType)) as ICatalogItemFiltringSpecification;

            var catalogItemReposity = _container.Resolve(typeof(ICatalogItemRepository<>).MakeGenericType(catalogItemType)) as ICatalogItemRepository;

            var res = await catalogItemReposity.Count(filtringSpecification);
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> CatalogItems([FromBody]CatalogItemModelFilter catalogItemModelFilter)
        {
            // getting type of catalog item
            var catalogItemType = _catalogItemTypeDictionary.GetCatalogItemType(catalogItemModelFilter.TypeDiscriminator);

            var filtringSpecification = BuildSpecification(catalogItemModelFilter, catalogItemType);
            if (catalogItemModelFilter.SkippingPages < 0)
            {
                return NotFound();
            }
            filtringSpecification.ApplyPaging(catalogItemModelFilter.SkippingPages * 6, 6);

            // getting catalogItem repository
            var catalogItemReposity = _container.Resolve(typeof(ICatalogItemRepository<>).MakeGenericType(catalogItemType)) as ICatalogItemRepository;
            var catalogItems = await catalogItemReposity.List(filtringSpecification);

            // creation catalogItemModels
            var res = _catalogItemModelFactory.GetCatalogItemShortModels(catalogItems);
            if (res.Count == 0)
            {
                return NotFound();
            }
            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> Count([FromBody]CatalogItemModelFilter catalogItemModelFilter)
        {
            // getting type of catalog item
            var catalogItemType = _catalogItemTypeDictionary.GetCatalogItemType(catalogItemModelFilter.TypeDiscriminator);

            var filtringSpecification = BuildSpecification(catalogItemModelFilter, catalogItemType);

            // getting catalogItem repository
            var catalogItemReposity = _container.Resolve(typeof(ICatalogItemRepository<>).MakeGenericType(catalogItemType)) as ICatalogItemRepository;

            // getting catalog item count
            int catalogItems = await catalogItemReposity.Count(filtringSpecification);

            return Ok(catalogItems);
        }


        #region utility

        private ICatalogItemFiltringSpecification BuildSpecification(CatalogItemModelFilter catalogItemModelFilter, Type catalogItemType)
        {
            // getting dynamic filter of catalog item type
            var dynamicFilter = _container.Resolve(typeof(IDynamicFilter<>).MakeGenericType(catalogItemType)) as IFilterExpression;

            // preparation of valid predictions
            var predictions = _modelFilterToPredictionConverter.ConvertRang(catalogItemModelFilter.GetFilledlFilters());
            predictions = _propertyNameValidator.ExcludeMismatchedPredictions(predictions, catalogItemType);

            // configyre dynamic filter 
            _filterConfigurator.Configure(dynamicFilter, predictions);

            // configyre specification
            var filtringSpecification = _container.Resolve(typeof(ICatalogItemFiltringSpecification<>).MakeGenericType(catalogItemType)) as ICatalogItemFiltringSpecification;
            return filtringSpecification.ConfigyreSpecificaton(dynamicFilter);
        }

        #endregion
    }
}
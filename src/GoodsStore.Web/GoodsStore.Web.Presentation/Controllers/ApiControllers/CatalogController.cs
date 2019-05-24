using System;
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

        [HttpPost]
        public async Task<IActionResult> CatalogItems([FromBody]CatalogItemModelFilter catalogItemModelFilter)
        {
            // getting type of catalog item
            var catalogItemType = _catalogItemTypeDictionary.GetCatalogItemType(catalogItemModelFilter.TypeDiscriminator);

            var filtringSpecification = BuildSpecification(catalogItemModelFilter, catalogItemType);
            filtringSpecification.ApplyPaging(0, 6);

            // getting catalogItem repository
            var catalogItemReposity = _container.Resolve(typeof(ICatalogItemRepository<>).MakeGenericType(catalogItemType)) as ICatalogItemRepository;
            var catalogItems = await catalogItemReposity.List(filtringSpecification);

            // creation catalogItemModels
            var res = _catalogItemModelFactory.GetCatalogItemModels(catalogItems);

            return Ok(res);
        }

        [HttpPost]
        public async Task<IActionResult> CatalogItemsCount([FromBody]CatalogItemModelFilter catalogItemModelFilter)
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
using Autofac;
using GoodsStore.Core.Domain.Helpers;
using GoodsStore.Web.Framework.Controllers;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Models.CompositModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Core.Logic.Interfases.Filter;
using GoodsStore.Web.ViewModel.Interfaces.Converters;

namespace GoodsStore.Web.Presentation.Controllers.ApiControllers
{
    public class CatalogController : BaseApiController
    {
        private readonly ICatalogItemModelFactory _catalogItemModelFactory;
        private readonly IContainer _container;
        private readonly IModelFilterToPredictionConverter _modelFilterToPredictionConverter;
        private readonly IFilterConfigurator _filterConfigurator;
        private readonly CatalogItemTypeDictionary _catalogItemTypeDictionary;


        public CatalogController(
            ICatalogItemModelFactory catalogItemModelFactory,
            CatalogItemTypeDictionary catalogItemTypeDictionary,
            IContainer container,
            IModelFilterToPredictionConverter modelFilterToPredictionConverter,
            IFilterConfigurator filterConfigurator
            )
        {
            _catalogItemModelFactory = catalogItemModelFactory;
            _modelFilterToPredictionConverter = modelFilterToPredictionConverter;
            _filterConfigurator = filterConfigurator;
            _catalogItemTypeDictionary = catalogItemTypeDictionary;
            _container = container;

        }

        [HttpPost]
        public async Task<IActionResult> GetCatalogItems([FromBody]CatalogItemModelFilter catalogItemModelFilter)
        {
            // Манеджмент всем лучше сделать в контроллере
            var catalogItemType = _catalogItemTypeDictionary.GetCatalogItemType(catalogItemModelFilter.TypeDiscriminator);
            var dynamicFilter = _container.Resolve(typeof(IDynamicFilter<>).MakeGenericType(catalogItemType)) as IFilterExpression;

            var predictions = _modelFilterToPredictionConverter.ConvertRang(catalogItemModelFilter.GetFilledlFilters());
            _filterConfigurator.Configure(dynamicFilter, predictions);

            var filtringSpecification = _container.Resolve(typeof(ICatalogItemFiltringSpecification<>).MakeGenericType(catalogItemType)) as ICatalogItemFiltringSpecification;
            filtringSpecification.ConfigyreSpecificaton(dynamicFilter).ApplyPaging(0, 6);

            //var catalogItemFilter = dynamicFilter as IDynamicFilter<CatalogItem>;
            return Ok();
        }
    }
}
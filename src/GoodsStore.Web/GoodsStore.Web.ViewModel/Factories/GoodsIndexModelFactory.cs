using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Models.CompositModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsStore.Web.ViewModel.Factories
{
    public class GoodsIndexModelFactory : IGoodsIndexModelFactory
    {
        private readonly ICatalogItemFactory _catalogItemFactory;
        
        private readonly ICatalogItemParametersFactory _catalogItemParametersFactory;

        #region Ctor

        public GoodsIndexModelFactory(
            ICatalogItemFactory catalogItemFactory,
            ICatalogItemParametersFactory catalogItemParametersFactory)
        {
            _catalogItemFactory = catalogItemFactory;
           
            _catalogItemParametersFactory = catalogItemParametersFactory;
        }
        #endregion

        #region Implementation of IGoodsIndexModelFactory

        public async Task<GoodsIndexModel> BuildGoodsIndexModel(string productTypeName, IEnumerable<CatalogItem> catalogItems)
        {
            return new GoodsIndexModel()
            {
                TypeName = productTypeName,
                CatalogItemModels = _catalogItemFactory.GetCategoryItemModels(catalogItems),
                Parametrs = await _catalogItemParametersFactory.GetParametrsOfType(catalogItems.First())
            };
        }
        #endregion

        
    }
}
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
using GoodsStore.Core.Domain.Entities;

namespace GoodsStore.Web.ViewModel.Factories
{
    public class GoodsIndexModelFactory : IGoodsIndexModelFactory
    {
        private readonly ICatalogItemModelFactory _catalogItemModelFactory;
        
        private readonly ICatalogItemParametersFactory _catalogItemParametersFactory;

        #region Ctor

        public GoodsIndexModelFactory(
            ICatalogItemModelFactory catalogItemModelFactory,
            ICatalogItemParametersFactory catalogItemParametersFactory)
        {
            _catalogItemModelFactory = catalogItemModelFactory;
           
            _catalogItemParametersFactory = catalogItemParametersFactory;
        }
        #endregion

        #region Implementation of IGoodsIndexModelFactory

        public GoodsIndexModel BuildGoodsIndexModel(ItemType productType, IEnumerable<CatalogItem> catalogItems)
        {
            return new GoodsIndexModel()
            {
                TypeName = productType.UnitName,
                TypeDiscriminator = catalogItems.FirstOrDefault()?.Discriminator,
                CatalogItemModels = _catalogItemModelFactory.GetCatalogItemModels(catalogItems),
                Parametrs = _catalogItemParametersFactory.GetParametrsOfType(productType)
            };
        }
        #endregion

        
    }
}
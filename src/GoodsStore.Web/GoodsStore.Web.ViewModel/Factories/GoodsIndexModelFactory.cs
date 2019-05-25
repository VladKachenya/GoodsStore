using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Models.CompositModels;
using System.Collections.Generic;
using System.Linq;
using GoodsStore.Web.Framework.Interfaces.Factories;

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
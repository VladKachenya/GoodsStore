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

        private readonly IGeneratorsDictionary<IParametrsGenerator> _parametersGenerators;

        #region Ctor

        public GoodsIndexModelFactory(
            ICatalogItemModelFactory catalogItemModelFactory,
            IGeneratorsDictionary<IParametrsGenerator> parametersGenerators)
        {
            _catalogItemModelFactory = catalogItemModelFactory;

            _parametersGenerators = parametersGenerators;
        }
        #endregion

        #region Implementation of IGoodsIndexModelFactory

        public GoodsIndexModel BuildGoodsIndexModel(ItemType productType)
        {
            return new GoodsIndexModel()
            {
                TypeName = productType.UnitName,
                TypeDiscriminator = productType.UnitName,
                Parametrs = _parametersGenerators.GetGenerator(productType).GetParametrs(productType)
            };
        }
        #endregion


    }
}
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Keys;
using Microsoft.EntityFrameworkCore.Internal;

namespace GoodsStore.Web.Framework.Factories
{
    public class CatalogItemParametersFactory : ICatalogItemParametersFactory
    {
        private Dictionary<GoodsTypes, Func<ItemType, List<IParametr>>> _parametrGenerators;
        public CatalogItemParametersFactory(IEnumerable<IParametrsGenerator> parametrsGenerators)
        {
            _parametrGenerators = new Dictionary<GoodsTypes, Func<ItemType, List<IParametr>>>();
            foreach (var parametrGentrator in parametrsGenerators)
            {
                _parametrGenerators.Add(parametrGentrator.ProductKey, (it) => parametrGentrator.GetParametrs(it));
            }
        }

        public List<IParametr> GetParametrsOfType(ItemType itemType)
        {
            var key = (GoodsTypes) itemType.Id;
            if (_parametrGenerators.ContainsKey(key))
            {
                return _parametrGenerators[key].Invoke(itemType);
            }

            return _parametrGenerators[default(GoodsTypes)].Invoke(itemType);
        }
    }
}
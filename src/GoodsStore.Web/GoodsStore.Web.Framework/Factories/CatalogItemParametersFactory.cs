using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodsStore.Web.Framework.Factories
{
    public class CatalogItemParametersFactory : ICatalogItemParametersFactory
    {
        private Dictionary<string, Func<Task<List<IParametr>>>> _parametrGenerators;
        public CatalogItemParametersFactory(IEnumerable<IParametrsGenerator> parametrsGenerators)
        {
            _parametrGenerators = new Dictionary<string, Func<Task<List<IParametr>>>>();
            foreach (var parametrGentrator in parametrsGenerators)
            {
                _parametrGenerators.Add(parametrGentrator.ProductKey, () => parametrGentrator.GetParametrs());
            }
        }

        public async Task<List<IParametr>> GetParametrsOfType(CatalogItem catalogItem)
        {
            return await _parametrGenerators[catalogItem.Discriminator].Invoke();
        }
    }
}
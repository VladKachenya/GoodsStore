using System;
using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Framework.Interfaces.Factories;

namespace GoodsStore.Web.Framework.Factories
{
    public class GeneratorsDictionary<TGenerator> : IGeneratorsDictionary<TGenerator> where TGenerator : IGenerator
    {
        private Dictionary<string, TGenerator> _generators;
        public GeneratorsDictionary(IEnumerable<TGenerator> generators)
        {
            _generators = new Dictionary<string, TGenerator>();
            foreach (var generator in generators)
            {
                _generators.Add(generator.GoodsKey, generator);
            }
        }

        public TGenerator GetGenerator(ItemType itemType)
        {
            return GetGenerator(itemType.UnitName);
        }

        public TGenerator GetGenerator(CatalogItem catalogItem)
        {
            return GetGenerator(catalogItem.Description);
        }

        public TGenerator GetGenerator(string catalogItemTypeName)
        {
            if (_generators.ContainsKey(catalogItemTypeName))
            {
                return _generators[catalogItemTypeName];
            }
            return _generators[nameof(CatalogItem)];
        }

        public TGenerator GetGenerator(Type catalogItemType)
        {
            return GetGenerator(catalogItemType.Name);
        }
    }
}
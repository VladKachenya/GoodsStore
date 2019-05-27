using GoodsStore.Core.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GoodsStore.Core.Domain.Helpers
{
    public class CatalogItemTypeDictionary
    {
        private Dictionary<string, Type> _catalogItemTypes;
        private object _lockObject = new object();
        public CatalogItemTypeDictionary()
        {
            var typeConfigurations = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.BaseType == typeof(CatalogItem));
            _catalogItemTypes = new Dictionary<string, Type>();
            foreach (var typeConfiguration in typeConfigurations)
            {
                _catalogItemTypes.Add(typeConfiguration.Name, typeConfiguration);
            }
        }

        public Type GetCatalogItemType(string typeName)
        {
            lock (_lockObject)
            {
                if (!_catalogItemTypes.ContainsKey(typeName))
                {
                    throw new ArgumentException("The type not found");
                }

                return _catalogItemTypes[typeName];
            }
        }
    }
}
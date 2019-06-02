using System;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;

namespace GoodsStore.Web.Framework.Interfaces.Factories
{
    public interface IGeneratorsDictionary<out TGenerator> where TGenerator : IGenerator
    {
        TGenerator GetGenerator(ItemType itemType);
        TGenerator GetGenerator(CatalogItem catalogItem);
        TGenerator GetGenerator(string catalogItemTypeName);
        TGenerator GetGenerator(Type catalogItemType);
    }
}
using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Framework.Interfaces.Model;

namespace GoodsStore.Web.Framework.Interfaces.Factories
{
    public interface ITableItemsGenerator : IGenerator
    {
        List<ITableItem> GetItems(CatalogItem catalogItem);
    }
}
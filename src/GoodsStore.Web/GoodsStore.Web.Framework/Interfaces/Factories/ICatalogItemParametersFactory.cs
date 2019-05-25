using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Web.Framework.Interfaces.Model;

namespace GoodsStore.Web.Framework.Interfaces.Factories
{
    public interface ICatalogItemParametersFactory
    {
        //Task<List<IParametr>> GetParametrsOfType<TProductEntit>() where TProductEntit : CatalogItem;
        List<IParametr> GetParametrsOfType(ItemType catalogItem);
    }
}
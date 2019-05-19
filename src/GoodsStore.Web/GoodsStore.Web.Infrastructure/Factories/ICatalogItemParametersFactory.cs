using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Infrastructure.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;

namespace GoodsStore.Web.Infrastructure.Factories
{
    public interface ICatalogItemParametersFactory
    {
        //Task<List<IParametr>> GetParametrsOfType<TProductEntit>() where TProductEntit : CatalogItem;
        List<IParametr> GetParametrsOfType(ItemType catalogItem);
    }
}
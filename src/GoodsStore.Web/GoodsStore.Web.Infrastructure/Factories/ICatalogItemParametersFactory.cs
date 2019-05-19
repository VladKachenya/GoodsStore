using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Infrastructure.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodsStore.Web.Infrastructure.Factories
{
    public interface ICatalogItemParametersFactory
    {
        //Task<List<IParametr>> GetParametrsOfType<TProductEntit>() where TProductEntit : CatalogItem;
        Task<List<IParametr>> GetParametrsOfType(CatalogItem catalogItem);
    }
}
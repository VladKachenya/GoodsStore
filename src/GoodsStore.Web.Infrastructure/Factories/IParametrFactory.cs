using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Web.Infrastructure.Model;

namespace GoodsStore.Web.Infrastructure.Factories
{
    public interface IParametrFactory
    {
        //Task<List<IParametr>> GetParametrsOfType<TProductEntit>() where TProductEntit : CatalogItem;
        Task<List<IParametr>> GetParametrsOfType(CatalogItem catalogItem);
    }
}
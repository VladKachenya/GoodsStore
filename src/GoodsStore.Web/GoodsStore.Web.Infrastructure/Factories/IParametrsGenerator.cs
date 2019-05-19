using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Infrastructure.Model;

namespace GoodsStore.Web.Infrastructure.Factories
{
    public interface IParametrsGenerator
    {
        GoodsTypes ProductKey { get; }
        List<IParametr> GetParametrs(ItemType itemType);
    }
}
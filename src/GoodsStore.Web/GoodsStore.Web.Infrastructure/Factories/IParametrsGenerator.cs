using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Web.Infrastructure.Model;

namespace GoodsStore.Web.Infrastructure.Factories
{
    public interface IParametrsGenerator
    {
        string ProductKey { get; }
        Task<List<IParametr>> GetParametrs();
    }
}
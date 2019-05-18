using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Keys;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;

namespace GoodsStore.Web.Framework.Factories.ParametrsGenerators
{
    public class RefrigeratorParametrsesGenerator : IParametrsGenerator
    {
        public string ProductKey => GoodsKeys.RefrigeratorKey;
        public Task<List<IParametr>> GetParametrs()
        {
            // Worck here
            return null;
        }
    }
}
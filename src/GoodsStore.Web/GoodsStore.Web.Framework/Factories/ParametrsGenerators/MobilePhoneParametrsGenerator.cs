using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodsStore.Web.Framework.Factories.ParametrsGenerators
{
    public class MobilePhoneParametrsGenerator : IParametrsGenerator
    {
        public string ProductKey => GoodsKeys.MobilePhoneKey;
        public async Task<List<IParametr>> GetParametrs()
        {
            return new List<IParametr>();
        }
    }
}
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;

namespace GoodsStore.Web.Framework.Factories.ParametrsGenerators
{
    public class RefrigeratorParametrsesGenerator : CatalogItemParametrsGenerator
    {
        public RefrigeratorParametrsesGenerator(IParametrFactory parametrFactory) : base(parametrFactory)
        {
        }
        public override GoodsTypes ProductKey => GoodsTypes.Refrigerator;

        public override List<IParametr> GetParametrs(ItemType itemType)
        {
            var res = base.GetParametrs(itemType);
            // Тут из базы данных необходимо достовать максимальный и минимальный размер экрана
            res.Add(_parametrFactory.GetRangeParametr(1, 15, "Width"));
            res.Add(_parametrFactory.GetRangeParametr(1, 15, "Height"));
            res.Add(_parametrFactory.GetRangeParametr(1, 15, "Freezer сamera volume"));
            res.Add(_parametrFactory.GetRangeParametr(1, 15, "Refrigerator camera volume"));

            return res;
        }
    }
}
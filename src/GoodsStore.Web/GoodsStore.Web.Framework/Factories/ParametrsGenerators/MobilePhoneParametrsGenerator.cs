using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;

namespace GoodsStore.Web.Framework.Factories.ParametrsGenerators
{
    public class MobilePhoneParametrsGenerator : CatalogItemParametrsGenerator
    {
        public MobilePhoneParametrsGenerator(IParametrFactory parametrFactory) : base(parametrFactory)
        {
        }

        public override GoodsTypes ProductKey => GoodsTypes.MobilePhone;

        public override List<IParametr> GetParametrs(ItemType itemType)
        {
            var res = base.GetParametrs(itemType);
            // Тут из базы данных необходимо достовать максимальный и минимальный размер экрана
            res.Add(_parametrFactory.GetRangeParametr(1, 15, "Screen Diagonal"));
            return res;
        }


    }
}
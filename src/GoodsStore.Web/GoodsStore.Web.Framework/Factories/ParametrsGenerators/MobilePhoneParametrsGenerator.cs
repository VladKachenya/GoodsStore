using System;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Entities.Goods.HouseholdEquipment;
using GoodsStore.Core.Domain.Entities.Goods.Telephony;
using GoodsStore.Core.Domain.Interfaces.Repositories;
using GoodsStore.Core.Domain.Interfaces.Specifications;

namespace GoodsStore.Web.Framework.Factories.ParametrsGenerators
{
    public class MobilePhoneParametrsGenerator : CatalogItemParametrsGenerator<MobilePhone>
    {
        public MobilePhoneParametrsGenerator(
            IParametrFactory parametrFactory,
            IRepository<MobilePhone> repository,
            Func<ISpecification<MobilePhone>> spesificatioFunc
        ) : base(parametrFactory, repository, spesificatioFunc)
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
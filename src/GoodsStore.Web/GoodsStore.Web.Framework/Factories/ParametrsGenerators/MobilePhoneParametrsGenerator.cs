using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Goods.Telephony;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Web.Framework.Interfaces.Factories;
using GoodsStore.Web.Framework.Interfaces.Model;
using System;
using System.Collections.Generic;

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

            var diagonals = GetEntitiesWithMinMaxValOf(mp => mp.ScreenDiagonal);
            res.Add(_parametrFactory.GetRangeParametr(
                diagonals.Item1.ScreenDiagonal,
                diagonals.Item2.ScreenDiagonal,
                "Screen Diagonal",
                nameof(MobilePhone.ScreenDiagonal)));
            return res;
        }



    }
}
using System;
using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Goods.HouseholdEquipment;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Web.Framework.Factories;
using GoodsStore.Web.Framework.Interfaces.Factories;
using GoodsStore.Web.Framework.Interfaces.Model;

namespace GoodsStore.Web.ViewModel.Factories.ParametrsGenerators
{
    public class RefrigeratorParametrsesGenerator : BaseCatalogItemParametrsGenerator<Refrigerator>
    {
        public RefrigeratorParametrsesGenerator(
            IParametrFactory parametrFactory,
            IRepository<Refrigerator> repository,
            Func<ISpecification<Refrigerator>> spesificatioFunc
            ) : base(parametrFactory, repository, spesificatioFunc)
        {
        }
        public override string GoodsKey => nameof(Refrigerator);

        public override List<IFilterParametr> GetParametrs(ItemType itemType)
        {
            var res = base.GetParametrs(itemType);

            var minMaxWidth = GetEntitiesWithMinMaxValOf(r => r.Width);
            res.Add(_parametrFactory.GetRangeParametr(
                minMaxWidth.Item1.Width,
                minMaxWidth.Item2.Width,
                "Width",
                nameof(Refrigerator.Width)));

            var minMaxHeight = GetEntitiesWithMinMaxValOf(r => r.Height);
            res.Add(_parametrFactory.GetRangeParametr(
                minMaxHeight.Item1.Height,
                minMaxHeight.Item2.Height,
                "Height",
                nameof(Refrigerator.Height)));


            var minMaxFreezerCameraVolume = GetEntitiesWithMinMaxValOf(r => r.FreezerCameraVolume);
            res.Add(_parametrFactory.GetRangeParametr(
                minMaxFreezerCameraVolume.Item1.FreezerCameraVolume,
                minMaxFreezerCameraVolume.Item2.FreezerCameraVolume,
                "Freezer сamera volume",
                nameof(Refrigerator.FreezerCameraVolume)));

            var minMaxRefrigeratroCameraVolume = GetEntitiesWithMinMaxValOf(r => r.RefrigeratorCameraVolume);
            res.Add(_parametrFactory.GetRangeParametr(
                minMaxRefrigeratroCameraVolume.Item1.RefrigeratorCameraVolume,
                minMaxRefrigeratroCameraVolume.Item2.RefrigeratorCameraVolume,
                "Refrigerator camera volume",
                nameof(Refrigerator.RefrigeratorCameraVolume)));

            return res;
        }
    }
}
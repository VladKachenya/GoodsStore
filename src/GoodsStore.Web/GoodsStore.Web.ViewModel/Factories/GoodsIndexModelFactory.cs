using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Models.CompositModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsStore.Web.ViewModel.Factories
{
    public class GoodsIndexModelFactory : IGoodsIndexModelFactory
    {
        private readonly ICatalogItemFactory _catalogItemFactory;
        private readonly Func<IRangeParametr> _rangeParametrFactory;
        private readonly Func<IPhraseParametr> _phraseParametrFactory;
        private readonly Func<ISelectableListParametr> _selectebleListParametrFactory;
        private readonly IParametrFactory _parametrFactory;

        #region Ctor

        public GoodsIndexModelFactory(
            ICatalogItemFactory catalogItemFactory,
            Func<IRangeParametr> rangeParametrFactory,
            Func<IPhraseParametr> phraseParametrFactory,
            Func<ISelectableListParametr> selectebleListParametrFactory,
            IParametrFactory parametrFactory)
        {
            _catalogItemFactory = catalogItemFactory;
            _rangeParametrFactory = rangeParametrFactory;
            _phraseParametrFactory = phraseParametrFactory;
            _selectebleListParametrFactory = selectebleListParametrFactory;
            _parametrFactory = parametrFactory;
        }
        #endregion

        #region Implementation of IGoodsIndexModelFactory

        public async Task<GoodsIndexModel> BuildGoodsIndexModel(string productTypeName, IEnumerable<CatalogItem> catalogItems)
        {
            return new GoodsIndexModel()
            {
                TypeName = productTypeName,
                CatalogItemModels = _catalogItemFactory.GetCategoryItemModels(catalogItems),
                Parametrs = await _parametrFactory.GetParametrsOfType(catalogItems.First())
            };
        }
        #endregion

        private IParametr GetSelectebleListParametr(IEnumerable<BaseEntity> baseEntities, string parametName = "Some SelectebleList param")
        {
            var res = _selectebleListParametrFactory.Invoke();

            foreach (var baseEntity in baseEntities)
            {
                res.SelectListItems.Add(new SelectListItem()
                {
                    Text = baseEntity.Name,
                    Value = baseEntity.Id.ToString()
                });
            }

            res.ParametrName = parametName;
            return res;
        }

        private IParametr GetPhraseParametr(string parametName = "Some phrase param")
        {
            var res = _phraseParametrFactory.Invoke();

            res.ParametrName = parametName;
            return res;
        }

        private IParametr GetRangeParametr(double from, double to, string parametName = "Some range param")
        {
            var res = _rangeParametrFactory.Invoke();
            res.FromValue = from;
            res.ToValue = to;
            res.ParametrName = parametName;
            return res;
        }
    }
}
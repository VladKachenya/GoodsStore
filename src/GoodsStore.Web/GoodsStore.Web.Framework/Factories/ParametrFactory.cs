using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Framework.Interfaces.Factories;
using GoodsStore.Web.Framework.Interfaces.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace GoodsStore.Web.Framework.Factories
{
    public class ParametrFactory : IParametrFactory
    {
        private readonly Func<IRangeFilterParametr> _rangeParametrFactory;
        private readonly Func<IPhraseFilterParametr> _phraseParametrFactory;
        private readonly Func<ISelectableListFilterParametr> _selectebleListParametrFactory;

        #region ctor

        public ParametrFactory(
            Func<IRangeFilterParametr> rangeParametrFactory,
            Func<IPhraseFilterParametr> phraseParametrFactory,
            Func<ISelectableListFilterParametr> selectebleListParametrFactory)
        {
            _rangeParametrFactory = rangeParametrFactory;
            _phraseParametrFactory = phraseParametrFactory;
            _selectebleListParametrFactory = selectebleListParametrFactory;
        }
        #endregion


        #region Implementation of IParametrFactory
        public IFilterParametr GetSelectebleListParametr(IEnumerable<BaseEntity> baseEntities, string parametName, string propertyName)
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

            res.PublicName = parametName;
            res.ItemPropertyName = propertyName;
            return res;
        }

        public IFilterParametr GetPhraseParametr(string parametName, string propertyName)
        {
            var res = _phraseParametrFactory.Invoke();
            res.Phrase = string.Empty;
            res.PublicName = parametName;
            res.ItemPropertyName = propertyName;
            return res;
        }

        public IFilterParametr GetRangeParametr(double from, double to, string parametName, string propertyName, string dimension = null)
        {
            var res = _rangeParametrFactory.Invoke();
            res.FromValue = from;
            res.ToValue = to;
            res.PublicName = parametName;
            res.ItemPropertyName = propertyName;
            res.Dimension = dimension;
            return res;
        }
        #endregion
    }
}
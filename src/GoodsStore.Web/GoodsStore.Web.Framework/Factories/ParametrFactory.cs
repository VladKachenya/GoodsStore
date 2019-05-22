using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace GoodsStore.Web.Framework.Factories
{
    public class ParametrFactory : IParametrFactory
    {
        private readonly Func<IRangeParametr> _rangeParametrFactory;
        private readonly Func<IPhraseParametr> _phraseParametrFactory;
        private readonly Func<ISelectableListParametr> _selectebleListParametrFactory;

        #region ctor

        public ParametrFactory(
            Func<IRangeParametr> rangeParametrFactory,
            Func<IPhraseParametr> phraseParametrFactory,
            Func<ISelectableListParametr> selectebleListParametrFactory)
        {
            _rangeParametrFactory = rangeParametrFactory;
            _phraseParametrFactory = phraseParametrFactory;
            _selectebleListParametrFactory = selectebleListParametrFactory;
        }
        #endregion


        #region Implementation of IParametrFactory
        public IParametr GetSelectebleListParametr(IEnumerable<BaseEntity> baseEntities, string parametName, string propertyName)
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

        public IParametr GetPhraseParametr(string parametName, string propertyName)
        {
            var res = _phraseParametrFactory.Invoke();
            res.Phrase = string.Empty;
            res.PublicName = parametName;
            res.ItemPropertyName = propertyName;
            return res;
        }

        public IParametr GetRangeParametr(double from, double to, string parametName, string propertyName)
        {
            var res = _rangeParametrFactory.Invoke();
            res.FromValue = from;
            res.ToValue = to;
            res.PublicName = parametName;
            res.ItemPropertyName = propertyName;
            return res;
        }
        #endregion
    }
}
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
        public IParametr GetSelectebleListParametr(IEnumerable<BaseEntity> baseEntities, string parametName = "Some SelectebleList param")
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

        public IParametr GetPhraseParametr(string parametName = "Some phrase param")
        {
            var res = _phraseParametrFactory.Invoke();

            res.ParametrName = parametName;
            return res;
        }

        public IParametr GetRangeParametr(double from, double to, string parametName = "Some range param")
        {
            var res = _rangeParametrFactory.Invoke();
            res.FromValue = from;
            res.ToValue = to;
            res.ParametrName = parametName;
            return res;
        }
        #endregion
    }
}
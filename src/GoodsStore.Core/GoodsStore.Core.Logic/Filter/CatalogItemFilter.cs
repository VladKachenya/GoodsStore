using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Core.Infrastructure.Filter;
using System;
using System.Linq.Expressions;

namespace GoodsStore.Core.Logic.Filter
{
    public class CatalogItemFilter<TCatalogItem> : IFilterExpression, IDynamicFilter<TCatalogItem> where TCatalogItem : CatalogItem
    {
        public CatalogItemFilter()
        {
            ParameterExpression = Expression.Parameter(typeof(TCatalogItem), "data");
            var constOne = Expression.Constant(1);
            FinalExpression = Expression.Equal(constOne, constOne);
        }

        public Expression<Func<TCatalogItem, bool>> GetLambda()
            => Expression.Lambda<Func<TCatalogItem, bool>>(FinalExpression, ParameterExpression);

        public ParameterExpression ParameterExpression { get; set; }
        public BinaryExpression FinalExpression { get; set; }
    }
}
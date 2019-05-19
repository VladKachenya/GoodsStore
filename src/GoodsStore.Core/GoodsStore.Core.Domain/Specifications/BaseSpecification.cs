using System;
using System.Linq.Expressions;
using GoodsStore.Core.Domain.Interfaces.Specifications;

namespace GoodsStore.Core.Domain.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public virtual void ConfigyreSpecificaton(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public virtual void ConfigyreSpecificaton(Expression<Func<T, bool>> criteria, int skip, int take)
        {
            ConfigyreSpecificaton(criteria);
            ApplyPaging(skip, take);
        }


        public Expression<Func<T, bool>> Criteria { get; private set; }
        public int Take { get; private set; }
        public int Skip { get; private set; }
        public bool IsPagingEnabled { get; private set; }
        protected virtual void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }
    }
}
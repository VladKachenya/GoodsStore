using System;
using System.Linq.Expressions;
using GoodsStore.Core.Domain.Interfaces.Specifications;

namespace GoodsStore.Core.Domain.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
            
        }
        public virtual ISpecification<T> ConfigyreSpecificaton(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
            return this;
        }

        public virtual ISpecification<T> ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
            return this;
        }

        public virtual ISpecification<T> SetOrder(Expression<Func<T, object>> orderExpression, bool isDescending = false)
        {
            if (isDescending)
            {
                OrderBy = null;
                OrderByDescending = orderExpression;
            }
            else
            {
                OrderByDescending = null;
                OrderBy = orderExpression;
            }

            return this;
        }


        public Expression<Func<T, bool>> Criteria { get; private set; }
        public Expression<Func<T, object>> OrderBy { get; protected set; }
        public Expression<Func<T, object>> OrderByDescending { get; protected set; }

        public int Take { get; private set; }
        public int Skip { get; private set; }

        public bool IsPagingEnabled { get; private set; }
        
    }
}
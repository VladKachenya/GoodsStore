using System;
using System.Linq.Expressions;
using GoodsStore.Core.Domain.Specifications;

namespace GoodsStore.Data.DataAccess.Specifications
{
    public class Specification<T> : ISpecification<T>
    {
        public Specification()
        {
            
        }
        public virtual ISpecification<T> ConfigyreSpecificaton(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
            return this;
        }

        public virtual void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }

        public virtual ISpecification<T> SetOrderingBy(Expression<Func<T, object>> orderExpression)
        {
            OrderBy = orderExpression;
            OrderByDescending = null;
            return this;
        }

        public virtual ISpecification<T> SetOrderingByDescending(Expression<Func<T, object>> orderExpression)
        {
            OrderByDescending = orderExpression;
            OrderBy = null;
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
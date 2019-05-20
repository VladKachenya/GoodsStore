using System;
using System.Linq.Expressions;

namespace GoodsStore.Core.Domain.Interfaces.Specifications
{
    public interface ISpecification<T>
    {
        ISpecification<T> ConfigyreSpecificaton(Expression<Func<T, bool>> criteria);
        ISpecification<T> ApplyPaging(int skip, int take);
        ISpecification<T> SetOrder(Expression<Func<T, object>> orderExpression, bool isDescending = false);

        Expression<Func<T, bool>> Criteria { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
    }
}
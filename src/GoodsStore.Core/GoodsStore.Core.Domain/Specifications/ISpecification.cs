using System;
using System.Linq.Expressions;

namespace GoodsStore.Core.Domain.Specifications
{
    public interface ISpecification<T> : IPagingConfigurator
    {
        ISpecification<T> ConfigyreSpecificaton(Expression<Func<T, bool>> criteria);

        ISpecification<T> SetOrderingBy(Expression<Func<T, object>> orderExpression);
        ISpecification<T> SetOrderingByDescending(Expression<Func<T, object>> orderExpression);

        Expression<Func<T, bool>> Criteria { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }

    }

    public interface IPagingConfigurator
    {
        void ApplyPaging(int skip, int take);

        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
    }
}

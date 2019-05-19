using System;
using System.Linq.Expressions;

namespace GoodsStore.Core.Domain.Interfaces.Specifications
{
    public interface ISpecification<T>
    {
        void ConfigyreSpecificaton(Expression<Func<T, bool>> criteria);
        void ConfigyreSpecificaton(Expression<Func<T, bool>> criteria, int skip, int take);

        Expression<Func<T, bool>> Criteria { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
    }
}
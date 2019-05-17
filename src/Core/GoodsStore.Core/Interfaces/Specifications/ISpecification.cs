using System;
using System.Linq.Expressions;

namespace GoodsStore.Core.Interfaces.Specifications
{
    public interface ISpecification<T>
    {
        void ConfigyreSpecificaton(Expression<Func<T, bool>> criteria);
        Expression<Func<T, bool>> Criteria { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
    }
}
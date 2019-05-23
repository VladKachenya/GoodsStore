using System;
using System.Linq.Expressions;

namespace GoodsStore.Core.Domain.Specifications
{
    public interface IDynamicFilter<T> 
    {
        Expression<Func<T, bool>> GetLambda();
    }
}
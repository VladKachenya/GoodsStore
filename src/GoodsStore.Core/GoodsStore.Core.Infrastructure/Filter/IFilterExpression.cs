using System.Linq.Expressions;

namespace GoodsStore.Core.Infrastructure.Filter
{
    public interface IFilterExpression
    {
        ParameterExpression ParameterExpression { get; set; }
        BinaryExpression FinalExpression { get; set; }
    }
}
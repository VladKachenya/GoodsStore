using System.Linq.Expressions;

namespace GoodsStore.Core.Logic.Interfases.Filter
{
    public interface IFilterExpression
    {
        ParameterExpression ParameterExpression { get; set; }
        BinaryExpression FinalExpression { get; set; }
    }
}
using System.Linq.Expressions;
using GoodsStore.Core.Logic.Filter;
using GoodsStore.Core.Logic.Keys;

namespace GoodsStore.Core.Logic.Interfases.Filter
{
    public interface IExpressionGenerator
    {
        Expression GenerateExpression(IFilterExpression filterExpression, Prediction prediction);

        PredictionType PredictionType { get; }
    }
}
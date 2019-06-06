using System.Linq.Expressions;
using GoodsStore.Core.Logic.Keys;

namespace GoodsStore.Core.Infrastructure.Filter
{
    public interface IExpressionGenerator
    {
        Expression GenerateExpression(IFilterExpression filterExpression, Prediction prediction);

        PredictionType PredictionType { get; }
    }
}
using GoodsStore.Core.Logic.Interfases.Filter;
using GoodsStore.Core.Logic.Keys;
using System;
using System.Linq.Expressions;

namespace GoodsStore.Core.Logic.Filter.ExpressionGenerators
{
    public class ContainsExpressionGenerator : IExpressionGenerator
    {
        public Expression GenerateExpression(IFilterExpression filterExpression, Prediction prediction)
        {
            if (prediction == null)
            {
                throw new ArgumentNullException();
            }
            if (!(prediction is ContaingPrediction))
            {
                throw new ArgumentException($"Argument must be the {nameof(ContaingPrediction)} type!");
            }
            var containPrediction = prediction as ContaingPrediction;
            var left = Expression.Property(filterExpression.ParameterExpression, prediction.PropertyName);
            var right = Expression.Constant(containPrediction.Value);
            return Expression.Call(left, typeof(string).GetMethod(nameof(String.Contains), new[] { typeof(string) }), right);
        }

        public PredictionType PredictionType => PredictionType.Contains;
    }
}
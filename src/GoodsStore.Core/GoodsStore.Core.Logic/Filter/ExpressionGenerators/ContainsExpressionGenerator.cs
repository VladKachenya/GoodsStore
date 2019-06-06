using GoodsStore.Core.Infrastructure.Filter;
using GoodsStore.Core.Logic.Keys;
using System;
using System.Linq.Expressions;

namespace GoodsStore.Core.Logic.Filter.ExpressionGenerators
{
    public class ContainsExpressionGenerator : BaseExpressionGenerator<ContainsPrediction>, IExpressionGenerator
    {
        public override Expression GenerateExpression(IFilterExpression filterExpression, Prediction prediction)
        {
            var left = base.GenerateExpression(filterExpression, prediction);
            var containsPrediction = prediction as ContainsPrediction;

            var right = Expression.Constant(containsPrediction.Value);
            return Expression.Call(left, typeof(string).GetMethod(nameof(String.Contains), new[] { typeof(string) }), right);
        }

        public override PredictionType PredictionType => PredictionType.Contains;
    }
}
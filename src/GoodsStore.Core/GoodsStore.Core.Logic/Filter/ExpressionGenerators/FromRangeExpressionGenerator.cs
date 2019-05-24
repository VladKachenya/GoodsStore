using System;
using GoodsStore.Core.Logic.Interfases.Filter;
using GoodsStore.Core.Logic.Keys;
using System.Linq.Expressions;

namespace GoodsStore.Core.Logic.Filter.ExpressionGenerators
{
    public class FromRangeExpressionGenerator : BaseExpressionGenerator<FromRangePrediction>, IExpressionGenerator
    {
        public override Expression GenerateExpression(IFilterExpression filterExpression, Prediction prediction)
        {
            var left = base.GenerateExpression(filterExpression, prediction);
            var fromRangePrediction = prediction as FromRangePrediction;
            left = Expression.Call(left, typeof(object).GetMethod(nameof(ToString), Type.EmptyTypes));
            left = Expression.Call(typeof(double).GetMethod(nameof(double.Parse), new []{typeof(string)}), left);
            
            var from = Expression.Constant(fromRangePrediction.FromValue);
            var to = Expression.Constant(fromRangePrediction.ToValue);
            var greater = Expression.GreaterThan(left, from);
            var lesser = Expression.LessThan(left, to);
            return Expression.And(greater, lesser);
        }

        public override PredictionType PredictionType => PredictionType.FromRange;
    }
}
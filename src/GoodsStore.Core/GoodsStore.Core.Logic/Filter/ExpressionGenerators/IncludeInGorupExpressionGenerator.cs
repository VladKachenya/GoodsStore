using GoodsStore.Core.Infrastructure.Filter;
using GoodsStore.Core.Logic.Keys;
using System.Linq.Expressions;

namespace GoodsStore.Core.Logic.Filter.ExpressionGenerators
{
    public class IncludeInGorupExpressionGenerator : BaseExpressionGenerator<IncludeInGorupPrediction>, IExpressionGenerator
    {
        public override Expression GenerateExpression(IFilterExpression filterExpression, Prediction prediction)
        {
            var left = base.GenerateExpression(filterExpression, prediction);
            var includeInGorupPrediction = prediction as IncludeInGorupPrediction;

            var constOne = Expression.Constant(1);
            var constZero = Expression.Constant(0);
            Expression res = Expression.Equal(constOne, constZero);

            foreach (var value in includeInGorupPrediction.Values)
            {
                var right = Expression.Constant(value);
                var expression = Expression.Equal(left, right);
                res = Expression.Or(res, expression);
            }

            return res;
        }

        public override PredictionType PredictionType => PredictionType.IncludeInGorup;
    }
}
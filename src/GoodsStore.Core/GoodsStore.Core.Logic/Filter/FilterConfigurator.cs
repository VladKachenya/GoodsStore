using GoodsStore.Core.Infrastructure.Filter;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoodsStore.Core.Logic.Filter
{
    public class FilterConfigurator : IFilterConfigurator
    {
        private readonly IEnumerable<IExpressionGenerator> _expressionGenerators;

        public FilterConfigurator(IEnumerable<IExpressionGenerator> expressionGenerators)
        {
            _expressionGenerators = expressionGenerators;
        }

        public void Configure(IFilterExpression filterExpression, IEnumerable<Prediction> predictions)
        {
            foreach (var prediction in predictions)
            {
                var expression = _expressionGenerators.FirstOrDefault(eg => eg.PredictionType == prediction.PredictionType)
                    ?.GenerateExpression(filterExpression, prediction);
                if (expression != null)
                {
                    filterExpression.FinalExpression =
                    Expression.And(filterExpression.FinalExpression, expression);
                }
            }
        }
    }
}
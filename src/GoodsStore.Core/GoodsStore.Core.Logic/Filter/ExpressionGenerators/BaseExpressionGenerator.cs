using GoodsStore.Core.Infrastructure.Filter;
using GoodsStore.Core.Logic.Keys;
using System;
using System.Linq.Expressions;

namespace GoodsStore.Core.Logic.Filter.ExpressionGenerators
{
    public abstract class BaseExpressionGenerator<T> : IExpressionGenerator where T : Prediction
    {
        public virtual Expression GenerateExpression(IFilterExpression filterExpression, Prediction prediction)
        {
            if (prediction == null)
            {
                throw new ArgumentNullException();
            }
            if (!(prediction is T))
            {
                throw new ArgumentException($"Argument must be the {nameof(T)} type!");
            }
            return Expression.Property(filterExpression.ParameterExpression, prediction.PropertyName);
        }

        public abstract PredictionType PredictionType { get; }
    }
}
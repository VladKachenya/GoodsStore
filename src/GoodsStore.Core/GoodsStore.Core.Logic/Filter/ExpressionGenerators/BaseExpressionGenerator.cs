using System;
using System.Linq.Expressions;
using GoodsStore.Core.Logic.Interfases.Filter;
using GoodsStore.Core.Logic.Keys;

namespace GoodsStore.Core.Logic.Filter.ExpressionGenerators
{
    public abstract class BaseExpressionGenerator<T> : IExpressionGenerator where  T : Prediction
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
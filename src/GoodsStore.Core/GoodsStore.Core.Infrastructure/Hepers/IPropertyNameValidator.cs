using System;
using System.Collections.Generic;
using GoodsStore.Core.Infrastructure.Filter;

namespace GoodsStore.Core.Infrastructure.Hepers
{
    public interface IPropertyNameValidator
    {
        bool ValidatePropertyForType(Prediction prediction, Type type);

        IEnumerable<Prediction> ExcludeMismatchedPredictions(IEnumerable<Prediction> predictions, Type type);
    }
}
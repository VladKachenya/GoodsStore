using System;
using System.Collections.Generic;
using System.Linq;
using GoodsStore.Core.Logic.Filter;

namespace GoodsStore.Core.Logic.Interfases.Hepers
{
    public interface IPropertyNameValidator
    {
        bool ValidatePropertyForType(Prediction prediction, Type type);

        IEnumerable<Prediction> ExcludeMismatchedPredictions(IEnumerable<Prediction> predictions, Type type);
    }
}
using GoodsStore.Core.Infrastructure.Filter;
using GoodsStore.Core.Infrastructure.Hepers;
using GoodsStore.Core.Logic.Keys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodsStore.Core.Logic.Helpers
{
    public class PropertyNameValidator : IPropertyNameValidator
    {

        public bool ValidatePropertyForType(Prediction prediction, Type type)
        {
            var prop = type.GetProperties().SingleOrDefault(pi => pi.Name == prediction.PropertyName);

            if (prop == null)
            {
                return false;
            }

            var propType = prop.PropertyType;

            switch (prediction.PredictionType)
            {
                case PredictionType.Contains:
                    return propType == typeof(string);
                case PredictionType.FromRange:
                    return propType == typeof(float) ||
                           propType == typeof(double) ||
                           propType == typeof(decimal);
                case PredictionType.IncludeInGorup:
                    return propType == typeof(int);
            }

            return false;
        }

        public IEnumerable<Prediction> ExcludeMismatchedPredictions(IEnumerable<Prediction> predictions, Type type)
        {
            var res = new List<Prediction>();
            foreach (var prediction in predictions)
            {
                if (ValidatePropertyForType(prediction, type))
                {
                    res.Add(prediction);
                }
            }

            return res;
        }
    }
}
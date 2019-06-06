using GoodsStore.Core.Infrastructure.Filter;
using GoodsStore.Core.Logic.Keys;
using GoodsStore.Web.Framework.Converters;
using GoodsStore.Web.ViewModel.Interfaces.Converters;
using GoodsStore.Web.ViewModel.Models.CompositModels;

namespace GoodsStore.Web.ViewModel.Converters
{
    public class ModelFilterToPredictionConverter : BaseConverter<BaseModelFilter, Prediction>, IModelFilterToPredictionConverter
    {
        public override Prediction Convert(BaseModelFilter obj)
        {
            if (obj is PhraseModelFilter phraseFilter)
            {
                return new ContainsPrediction()
                {
                    PropertyName = phraseFilter.PropertyName,
                    PredictionType = PredictionType.Contains,
                    Value = phraseFilter.Value
                };
            }

            if (obj is RangeModelFilter rangeFilter)
            {
                double from = rangeFilter.FromValue.HasValue ? rangeFilter.FromValue.Value : double.MinValue;
                double to = rangeFilter.ToValue.HasValue ? rangeFilter.ToValue.Value : double.MaxValue;
                return new FromRangePrediction()
                {
                    PropertyName = rangeFilter.PropertyName,
                    PredictionType = PredictionType.FromRange,
                    FromValue = from,
                    ToValue = to
                };
            }

            if (obj is GroupModelFilter groupFilter)
            {
                return new IncludeInGorupPrediction()
                {
                    PropertyName = groupFilter.PropertyName,
                    PredictionType = PredictionType.IncludeInGorup,
                    Values = groupFilter.Values
                };
            }

            return new Prediction()
            {
                PropertyName = obj.PropertyName,
                PredictionType = 0
            };
        }
    }
}
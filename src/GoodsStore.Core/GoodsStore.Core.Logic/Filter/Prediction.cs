using GoodsStore.Core.Logic.Keys;

namespace GoodsStore.Core.Logic.Filter
{
    public class Prediction
    {
        public string PropertyName { get; set; }
        public PredictionType PredictionType { get; set; }
    }

    public class ContaingPrediction : Prediction
    {
        public string Value { get; set; }
    }
    public class FromRangePrediction : Prediction
    {
        public double FromValue { get; set; }
        public double ToValue { get; set; }
    }

    public class IncludeInGorup : Prediction
    {
        public int[] Values { get; set; }
    }
}
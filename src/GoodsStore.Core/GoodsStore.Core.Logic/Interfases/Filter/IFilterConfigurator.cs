using System.Collections.Generic;
using GoodsStore.Core.Logic.Filter;

namespace GoodsStore.Core.Logic.Interfases.Filter
{
    public interface IFilterConfigurator
    {
        void Configure(IFilterExpression filterExpression, IEnumerable<Prediction> predictions);
    }
}
using System.Collections.Generic;

namespace GoodsStore.Core.Infrastructure.Filter
{
    public interface IFilterConfigurator
    {
        void Configure(IFilterExpression filterExpression, IEnumerable<Prediction> predictions);
    }
}
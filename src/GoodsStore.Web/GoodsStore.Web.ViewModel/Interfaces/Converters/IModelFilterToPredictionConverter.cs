using GoodsStore.Core.Infrastructure.Filter;
using GoodsStore.Web.Framework.Interfaces.Converters;
using GoodsStore.Web.ViewModel.Models.CompositModels;

namespace GoodsStore.Web.ViewModel.Interfaces.Converters
{
    public interface IModelFilterToPredictionConverter : IConverter<BaseModelFilter, Prediction>
    {

    }
}
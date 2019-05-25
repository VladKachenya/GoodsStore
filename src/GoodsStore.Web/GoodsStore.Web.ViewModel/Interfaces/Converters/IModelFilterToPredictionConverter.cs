using GoodsStore.Core.Logic.Filter;
using GoodsStore.Web.Framework.Interfaces.Converters;
using GoodsStore.Web.ViewModel.Models.CompositModels;

namespace GoodsStore.Web.ViewModel.Interfaces.Converters
{
    public interface IModelFilterToPredictionConverter : IConverter<BaseModelFilter, Prediction>
    {
        
    }
}
using GoodsStore.Core.Entities;

namespace GoodsStore.Web.ViewModel.Interfaces.Servicies
{
    public interface ICategoryModelService
    {
        string GetCategoryIconName(Category category);
    }
}
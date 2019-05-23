using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.ViewModel.Interfaces.Servicies;
using GoodsStore.Web.ViewModel.Models.CompositModels;

namespace GoodsStore.Web.ViewModel.Servicies
{
    public class CategoryModelService : ICategoryModelService
    {
        public string GetCategoryIconName(Category category)
        {
            // for implementation
            return string.Empty;
        }

    }
}
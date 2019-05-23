using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.ViewModel.Models.CompositModels;

namespace GoodsStore.Web.ViewModel.Interfaces.Servicies
{
    public interface ICategoryModelService
    {
        string GetCategoryIconName(Category category);

    }
}
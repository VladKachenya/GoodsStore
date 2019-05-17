using System.Collections.Generic;
using GoodsStore.Core.Entities;
using GoodsStore.Web.ViewModel.Models;

namespace GoodsStore.Web.ViewModel.Interfaces.Factories
{
    public interface ICategoryModelFactory
    {
        CategoryModel GetCategoryModel(Category category);

        List<CategoryModel> GetCategoryModels(IEnumerable<Category> categories);

    }
}
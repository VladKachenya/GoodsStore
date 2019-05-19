using GoodsStore.Core.Domain.Entities;
using GoodsStore.Web.ViewModel.Models;
using System.Collections.Generic;

namespace GoodsStore.Web.ViewModel.Interfaces.Factories
{
    public interface ICategoryModelFactory
    {
        CategoryModel GetCategoryModel(Category category);

        List<CategoryModel> GetCategoryModels(IEnumerable<Category> categories);

    }
}
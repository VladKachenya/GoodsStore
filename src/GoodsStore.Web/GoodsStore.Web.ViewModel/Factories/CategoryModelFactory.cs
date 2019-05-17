using System.Collections.Generic;
using System.Linq;
using GoodsStore.Core.Entities;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Interfaces.Servicies;
using GoodsStore.Web.ViewModel.Models;

namespace GoodsStore.Web.ViewModel.Factories
{
    public class CategoryModelFactory : ICategoryModelFactory
    {
        private readonly ICategoryModelService _categoryModelService;

        public CategoryModelFactory(ICategoryModelService categoryModelService)
        {
            _categoryModelService = categoryModelService;
        }

        public CategoryModel GetCategoryModel(Category category)
        {
            return new CategoryModel()
            {
                Id = category.Id,
                CategoryName = category.CategoryName,
                IconName = _categoryModelService.GetCategoryIconName(category),
                ItemTypeModels = category.ItemTypes.Select(it => new ItemTypeModel(){Id = it.Id, ItemTypeName = it.TypeName})
            };
        }

        public List<CategoryModel> GetCategoryModels(IEnumerable<Category> categories)
        {
            var res = new List<CategoryModel>();
            foreach (var category in categories)
            {
                res.Add(GetCategoryModel(category));
            }
            return res;
        }
        
    }
}
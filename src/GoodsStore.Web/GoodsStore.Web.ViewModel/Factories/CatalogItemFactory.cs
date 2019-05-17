using GoodsStore.Core.Entities;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Models;
using System.Collections.Generic;

namespace GoodsStore.Web.ViewModel.Factories
{
    public class CatalogItemFactory : ICatalogItemFactory
    {
        public CatalogItemModel GetCategoryItemModel(CatalogItem categoryModel)
        {
            return new CatalogItemModel()
            {
                Id = categoryModel.Id,
                Description = categoryModel.Description,
                Price = categoryModel.Price,
                Name = categoryModel.Name
            };
        }

        public List<CatalogItemModel> GetCategoryItemModels(IEnumerable<CatalogItem> categoryModels)
        {
            var res = new List<CatalogItemModel>();
            foreach (var categoryModel in categoryModels)
            {
                res.Add(GetCategoryItemModel(categoryModel));
            }

            return res;
        }
    }
}
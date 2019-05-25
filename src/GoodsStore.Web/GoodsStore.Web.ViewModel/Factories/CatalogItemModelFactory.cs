using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Framework.Keys;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Models;
using System.Collections.Generic;

namespace GoodsStore.Web.ViewModel.Factories
{
    public class CatalogItemModelFactory : ICatalogItemModelFactory
    {
        public CatalogItemModel GetCatalogItemModel(CatalogItem categoryModel)
        {
            return new CatalogItemModel()
            {
                Id = categoryModel.Id,
                Description = categoryModel.Description,
                Price = categoryModel.Price,
                Model = categoryModel.Name,
                UnitName = categoryModel.ItemType.UnitName,
                Brand = categoryModel.Brand.Name,
                PictureUri = string.IsNullOrWhiteSpace(categoryModel.PictureUri)
                    ? PresentationConstants.ImagePlaceHolderUrl
                    : categoryModel.PictureUri
            };
        }

        public List<CatalogItemModel> GetCatalogItemModels(IEnumerable<CatalogItem> categoryModels)
        {
            var res = new List<CatalogItemModel>();
            foreach (var categoryModel in categoryModels)
            {
                res.Add(GetCatalogItemModel(categoryModel));
            }
            return res;
        }
    }
}
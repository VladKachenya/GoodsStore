using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Framework.Keys;
using GoodsStore.Web.ViewModel.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Models;
using System.Collections.Generic;
using GoodsStore.Web.Framework.Interfaces.Factories;
using GoodsStore.Web.ViewModel.Models.CompositModels;

namespace GoodsStore.Web.ViewModel.Factories
{
    public class CatalogItemModelFactory : ICatalogItemModelFactory
    {
        private readonly IGeneratorsDictionary<ITableItemsGenerator> _generatorsDictionary;

        public CatalogItemModelFactory(
            IGeneratorsDictionary<ITableItemsGenerator> generatorsDictionary)
        {
            _generatorsDictionary = generatorsDictionary;
        }
        public CatalogItemShortModel GetCatalogItemShortModel(CatalogItem catalogItem)
        {
            return new CatalogItemShortModel()
            {
                Id = catalogItem.Id,
                Description = catalogItem.Description,
                Price = catalogItem.Price,
                Model = catalogItem.Name,
                UnitName = catalogItem.ItemType.UnitName,
                Brand = catalogItem.Brand.Name,
                PictureUri = string.IsNullOrWhiteSpace(catalogItem.PictureUri)
                    ? PresentationConstants.ImagePlaceHolderUrl
                    : catalogItem.PictureUri
            };
        }

        public List<CatalogItemShortModel> GetCatalogItemShortModels(IEnumerable<CatalogItem> catalogItems)
        {
            var res = new List<CatalogItemShortModel>();
            foreach (var categoryModel in catalogItems)
            {
                res.Add(GetCatalogItemShortModel(categoryModel));
            }
            return res;
        }

        public CatalogItemModel GetCatalogItemModel(CatalogItem catalogItem)
        {
            var res = new CatalogItemModel();
            res.CatalogItemShortModel = GetCatalogItemShortModel(catalogItem);
            res.Table = _generatorsDictionary.GetGenerator(catalogItem).GetItems(catalogItem);
            return res;
        }

    }
}
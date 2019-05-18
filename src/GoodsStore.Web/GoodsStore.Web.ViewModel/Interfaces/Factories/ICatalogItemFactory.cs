using System.Collections.Generic;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Web.ViewModel.Models;

namespace GoodsStore.Web.ViewModel.Interfaces.Factories
{
    public interface ICatalogItemFactory
    {
        CatalogItemModel GetCategoryItemModel(CatalogItem categoryModel);
        List<CatalogItemModel> GetCategoryItemModels(IEnumerable<CatalogItem> categoryModels);

    }
}
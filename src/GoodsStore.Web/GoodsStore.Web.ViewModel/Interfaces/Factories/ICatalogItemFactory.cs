using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.ViewModel.Models;
using System.Collections.Generic;

namespace GoodsStore.Web.ViewModel.Interfaces.Factories
{
    public interface ICatalogItemFactory
    {
        CatalogItemModel GetCategoryItemModel(CatalogItem categoryModel);
        List<CatalogItemModel> GetCategoryItemModels(IEnumerable<CatalogItem> categoryModels);

    }
}
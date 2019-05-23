using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.ViewModel.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Web.ViewModel.Models.CompositModels;

namespace GoodsStore.Web.ViewModel.Interfaces.Factories
{
    public interface ICatalogItemModelFactory
    {
        CatalogItemModel GetCatalogItemModel(CatalogItem categoryModel);
        List<CatalogItemModel> GetCatalogItemModels(IEnumerable<CatalogItem> categoryModels);

    }
}
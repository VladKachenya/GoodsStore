using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.ViewModel.Models.CompositModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodsStore.Web.ViewModel.Interfaces.Factories
{
    public interface IGoodsIndexModelFactory
    {
        Task<GoodsIndexModel> BuildGoodsIndexModel(string productTypeName, IEnumerable<CatalogItem> catalogItems);
    }
}
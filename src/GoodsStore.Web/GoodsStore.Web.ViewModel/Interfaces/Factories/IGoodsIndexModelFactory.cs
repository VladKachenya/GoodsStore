using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Web.ViewModel.Models.CompositModels;

namespace GoodsStore.Web.ViewModel.Interfaces.Factories
{
    public interface IGoodsIndexModelFactory
    {
        Task<GoodsIndexModel> BuildGoodsIndexModel(string productTypeName,  IEnumerable<CatalogItem> catalogItems);
    }
}
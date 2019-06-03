using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.ViewModel.Models.CompositModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;

namespace GoodsStore.Web.ViewModel.Interfaces.Factories
{
    public interface IGoodsIndexModelFactory
    {
        GoodsIndexModel BuildGoodsIndexModel(ItemType productType);
    }
}
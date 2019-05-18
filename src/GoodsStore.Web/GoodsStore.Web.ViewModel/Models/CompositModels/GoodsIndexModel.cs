using System.Collections.Generic;
using GoodsStore.Web.Infrastructure.Model;

namespace GoodsStore.Web.ViewModel.Models.CompositModels
{
    public class GoodsIndexModel
    {
        public string TypeName { get; set; }

        public List<CatalogItemModel> CatalogItemModels { get; set; }

        public List<IParametr> Parametrs { get; set; } 
    }
}
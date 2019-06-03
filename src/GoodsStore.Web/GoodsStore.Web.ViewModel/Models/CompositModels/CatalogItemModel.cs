using System.Collections.Generic;
using GoodsStore.Web.Framework.Interfaces.Model;

namespace GoodsStore.Web.ViewModel.Models.CompositModels
{
    public class CatalogItemModel 
    {
        public CatalogItemShortModel CatalogItemShortModel { get; set; }
        public List<ITableItem> Table { get; set; }
    }
}
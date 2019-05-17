using GoodsStore.Web.Framework.Models;

namespace GoodsStore.Web.ViewModel.Models
{
    public class CatalogItemModel : BaseEntityModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
using GoodsStore.Web.Framework.Models;

namespace GoodsStore.Web.ViewModel.Models
{
    public class CatalogItemShortModel : BaseEntityModel
    {
        public string PictureUri { get; set; }
        public string Brand { get; set; }
        public string UnitName { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
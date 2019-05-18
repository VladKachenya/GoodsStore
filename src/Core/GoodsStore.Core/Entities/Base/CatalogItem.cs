namespace GoodsStore.Core.Entities.Base
{
    public class CatalogItem : BaseEntity
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int ItemTypeId { get; set; }
        public string PictureUri { get; set; }
        public ItemType ItemType { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        
        public string Discriminator { get; set; }

    }
}
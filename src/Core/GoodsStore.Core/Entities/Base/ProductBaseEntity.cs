namespace GoodsStore.Core.Entities.Base
{
    public abstract class ProductBaseEntity : BaseEntity
    {
        public int CatalogItemId { get; set; }
        public CatalogItem CatalogItem { get; set; }
    }
}
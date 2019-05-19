namespace GoodsStore.Core.Domain.Entities.Helpers
{
    public class BrandItemType
    {
        public int ItemTypeId { get; set; }
        public virtual ItemType ItemType { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
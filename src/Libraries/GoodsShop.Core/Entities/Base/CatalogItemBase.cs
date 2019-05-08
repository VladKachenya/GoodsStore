﻿namespace GoodsShop.Core.Entities.Base
{
    public abstract class CatalogItemBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int ItemTypeId { get; set; }
        public ItemType ItemType { get; set; }
        public int ItemBrandId { get; set; }
        public ItemBrand ItemBrand { get; set; }
    }
}
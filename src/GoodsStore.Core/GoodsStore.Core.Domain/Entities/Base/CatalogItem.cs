﻿namespace GoodsStore.Core.Domain.Entities.Base
{
    public class CatalogItem : BaseEntity
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }

        // This is block will be replaced by "BrandItemType" may be
        public int ItemTypeId { get; set; }
        public virtual ItemType ItemType { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        ////

        public string Discriminator { get; set; }

    }
}
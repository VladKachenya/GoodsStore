using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.DataAccess.Mapping
{
    public class CatalogItemMap : EntityConfig<CatalogItem>
    {
        public override void Configure(EntityTypeBuilder<CatalogItem> builder)
        {
            builder.ToTable("CatalogItems");
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Brand).WithMany().HasForeignKey(c => c.BrandId).IsRequired();
            builder.HasOne(c => c.ItemType).WithMany().HasForeignKey(c => c.ItemTypeId).IsRequired();

        }
    }
}
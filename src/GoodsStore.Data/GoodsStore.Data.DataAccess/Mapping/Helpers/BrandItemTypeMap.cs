using GoodsStore.Core.Domain.Entities.Helpers;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.DataAccess.Mapping.Helpers
{
    public class BrandItemTypeMap : BaseConfig<BrandItemType>
    {
        public override void Configure(EntityTypeBuilder<BrandItemType> builder)
        {
            builder.ToTable("BrandItemTypes");
            builder.HasKey(t => new { t.BrandId, t.ItemTypeId });

            builder.HasOne(bi => bi.Brand)
                .WithMany(b => b.BrandItemTypes)
                .HasForeignKey(bi => bi.BrandId);

            builder.HasOne(bi => bi.ItemType)
                .WithMany(it => it.BrandItemTypes)
                .HasForeignKey(bi => bi.ItemTypeId);
        }
    }
}
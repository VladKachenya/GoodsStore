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

            builder.HasData(new[]
            {
                new BrandItemType(){BrandId = 5, ItemTypeId = 1},
                new BrandItemType(){BrandId = 4, ItemTypeId = 1},
                new BrandItemType(){BrandId = 1, ItemTypeId = 1},
                new BrandItemType(){BrandId = 6, ItemTypeId = 1},
                new BrandItemType(){BrandId = 4, ItemTypeId = 3},
                new BrandItemType(){BrandId = 2, ItemTypeId = 3},
                new BrandItemType(){BrandId = 1, ItemTypeId = 3},
            });
        }
    }
}
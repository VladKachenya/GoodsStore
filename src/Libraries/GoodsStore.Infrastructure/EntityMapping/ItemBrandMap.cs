using GoodsStore.Core.Entities;
using GoodsStore.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Infrastructure.EntityMapping
{
    public class ItemBrandMap : GoodsStoreEntityTypeConfiguration<Brand>
    {

        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");
            builder.Property(p => p.BrandName).IsRequired().HasMaxLength(30);
        }
    }
}
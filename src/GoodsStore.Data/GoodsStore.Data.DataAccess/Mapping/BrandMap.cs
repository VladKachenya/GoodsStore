using GoodsStore.Core.Entities;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.DataAccess.Mapping 
{
    public class BrandMap : EntityConfig<Brand>
    {

        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");
            builder.Property(p => p.BrandName).IsRequired().HasMaxLength(30);
            builder.HasData(new Brand[]
            {
                new Brand(){Id = 1, BrandName = "Samsung"},
                new Brand(){Id = 2, BrandName = "Simens"},
                new Brand(){Id = 3, BrandName = "Xiaomi"},
                new Brand(){Id = 4, BrandName = "LG"},
                new Brand(){Id = 5, BrandName = "ATLANT"},
                new Brand(){Id = 6, BrandName = "Bosch"}
            });
        }
    }
}
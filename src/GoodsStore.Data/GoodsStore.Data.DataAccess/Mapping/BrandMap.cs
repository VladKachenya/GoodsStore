using GoodsStore.Core.Domain.Entities;
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
            builder.Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.HasData(new Brand[]
            {
                new Brand(){Id = 1, Name = "Samsung"},
                new Brand(){Id = 2, Name = "Simens"},
                new Brand(){Id = 3, Name = "Xiaomi"},
                new Brand(){Id = 4, Name = "LG"},
                new Brand(){Id = 5, Name = "ATLANT"},
                new Brand(){Id = 6, Name = "Bosch"}
            });
        }
    }
}
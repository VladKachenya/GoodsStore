using GoodsStore.Core.Entities.Goods.HouseholdEquipment;
using GoodsStore.Infrastructure.MappingBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Infrastructure.EntityMapping.Goods.HouseholdEquipment
{
    public class RefrigeratorMap : ProductEntityConfig<Refrigerator>
    {
        public override void Configure(EntityTypeBuilder<Refrigerator> builder)
        {
            builder.ToTable("Refrigerators");
            builder.HasKey(r => r.Id);
            base.Configure(builder);

            builder.HasData( new Refrigerator[]
            {
                new Refrigerator(){Id = 1, CatalogItemId = 1, Height = 10, Width = 5, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 20},
                new Refrigerator(){Id = 2, CatalogItemId = 2, Height = 10, Width = 6, FreezerCameraVolume = 12, RefrigeratorCameraVolume = 25},
                new Refrigerator(){Id = 3, CatalogItemId = 3, Height = 12, Width = 7, FreezerCameraVolume = 20, RefrigeratorCameraVolume = 22},
                new Refrigerator(){Id = 4, CatalogItemId = 4, Height = 15, Width = 4, FreezerCameraVolume = 30, RefrigeratorCameraVolume = 29},
                new Refrigerator(){Id = 5, CatalogItemId = 5, Height = 8, Width = 8, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 20},
                new Refrigerator(){Id = 6, CatalogItemId = 6, Height = 15, Width = 5, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 33},

            });
        }
    }
}
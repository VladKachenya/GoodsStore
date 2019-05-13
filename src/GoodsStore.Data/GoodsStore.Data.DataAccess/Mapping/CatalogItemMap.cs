using GoodsStore.Core.Entities;
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

            builder.HasData(new CatalogItem[]
            {
                new CatalogItem(){Id = 1, BrandId = 1, ItemTypeId = 1, Price = (decimal)12.25, Name = "XM 4208-000", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium"},
                new CatalogItem(){Id = 2, BrandId = 1, ItemTypeId = 1, Price = (decimal)89.25, Name = "XM 4215-000", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium"},
                new CatalogItem(){Id = 3, BrandId = 1, ItemTypeId = 1, Price = (decimal)124.145, Name = "XM 4307-001", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium"},
                new CatalogItem(){Id = 4, BrandId = 2, ItemTypeId = 1, Price = (decimal)142.125, Name = "GA-B429SMQZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising"},
                new CatalogItem(){Id = 5, BrandId = 2, ItemTypeId = 1, Price = (decimal)1110.25, Name = "GW-B499SMFZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising"},
                new CatalogItem(){Id = 6, BrandId = 2, ItemTypeId = 1, Price = (decimal)1210.2, Name = "GA-B499YMQZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising"},

                new CatalogItem(){Id = 7, BrandId = 4, ItemTypeId = 3, Price = (decimal)12.25, Name = "V30S+ ThinQ Gray", Description = "Li Europan lingues es membres del sam familie. Lor separat existentie es un myth."},
                new CatalogItem(){Id = 8, BrandId = 4, ItemTypeId = 3, Price = (decimal)782.25, Name = "G360", Description = "Por scientie, musica, sport etc, litot Europa usa li sam vocabular."},
                new CatalogItem(){Id = 9, BrandId = 4, ItemTypeId = 3, Price = (decimal)152.25, Name = "V40 ThinQ 64Gb Black", Description = " Li lingues differe solmen in li grammatica, li pronunciation e li plu commun vocabules."},

            });
        }
    }
}
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
                new CatalogItem(){Id = 1, BrandId = 5, ItemTypeId = 1, Price = (decimal)12.25, Model = "XM 4208-000", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium"},
                new CatalogItem(){Id = 2, BrandId = 5, ItemTypeId = 1, Price = (decimal)89.25, Model = "XM 4215-000", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium"},
                new CatalogItem(){Id = 3, BrandId = 5, ItemTypeId = 1, Price = (decimal)124.145, Model = "XM 4307-001", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium"},
                new CatalogItem(){Id = 4, BrandId = 4, ItemTypeId = 1, Price = (decimal)142.125, Model = "GA-B429SMQZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising"},
                new CatalogItem(){Id = 5, BrandId = 4, ItemTypeId = 1, Price = (decimal)1110.25, Model = "GW-B499SMFZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising"},
                new CatalogItem(){Id = 6, BrandId = 4, ItemTypeId = 1, Price = (decimal)1210.2, Model = "GA-B499YMQZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising"},

                new CatalogItem(){Id = 7, BrandId = 4, ItemTypeId = 3, Price = (decimal)12.25, Model = "V30S+ ThinQ Gray", Description = "Li Europan lingues es membres del sam familie. Lor separat existentie es un myth."},
                new CatalogItem(){Id = 8, BrandId = 4, ItemTypeId = 3, Price = (decimal)782.25, Model = "G360", Description = "Por scientie, musica, sport etc, litot Europa usa li sam vocabular."},
                new CatalogItem(){Id = 9, BrandId = 4, ItemTypeId = 3, Price = (decimal)152.25, Model = "V40 ThinQ 64Gb Black", Description = " Li lingues differe solmen in li grammatica, li pronunciation e li plu commun vocabules."},

                new CatalogItem(){Id = 10, BrandId = 1, ItemTypeId = 1, Price = (decimal)142, Model = "RB33J3200SA", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising"},
                new CatalogItem(){Id = 11, BrandId = 1, ItemTypeId = 1, Price = (decimal)578, Model = "RS55K50A02C", Description = "So perhaps, you've generated some fancy text, and you're content that you can now copy and paste"},
                new CatalogItem(){Id = 12, BrandId = 1, ItemTypeId = 1, Price = (decimal)74.25, Model = "RT22HAR4DSA", Description = "Is it some sort of hack? Are you copying and pasting an actual font?"},
                new CatalogItem(){Id = 13, BrandId = 1, ItemTypeId = 1, Price = (decimal)125.12, Model = "RB34N5061B1/WT", Description = "Sudden she seeing garret far regard. By hardly it direct if pretty up regret."},
                new CatalogItem(){Id = 14, BrandId = 1, ItemTypeId = 1, Price = (decimal)111.1, Model = "RB37J5441SA", Description = "Ability thought enquire settled prudent you sir."},
                new CatalogItem(){Id = 15, BrandId = 1, ItemTypeId = 1, Price = (decimal)794.2, Model = "RS54N3003WW/WT", Description = "Or easy knew sold on well come year. Something consulted age extremely end procuring."},
                new CatalogItem(){Id = 16, BrandId = 1, ItemTypeId = 1, Price = (decimal)541.1, Model = "RB37J5000SA", Description = "Collecting preference he inquietude projection me in by."},
                new CatalogItem(){Id = 17, BrandId = 1, ItemTypeId = 1, Price = (decimal)999.99, Model = "RB37J5240SS", Description = "So do of sufficient projecting an thoroughly uncommonly prosperous conviction."},
                new CatalogItem(){Id = 18, BrandId = 6, ItemTypeId = 1, Price = (decimal)231.1, Model = "KGN39XL2AR", Description = "Betrayed cheerful declared end and."},
                new CatalogItem(){Id = 19, BrandId = 6, ItemTypeId = 1, Price = (decimal)452.1, Model = "KGN39XW2AR", Description = "Questions we additions is extremely incommode. Next half add call them eat face."},
                new CatalogItem(){Id = 20, BrandId = 6, ItemTypeId = 1, Price = (decimal)123.1, Model = "KGN39AI31R", Description = "Age lived smile six defer bed their few. Had admitting concluded too behaviour him she."},
                new CatalogItem(){Id = 21, BrandId = 6, ItemTypeId = 1, Price = (decimal)542.4, Model = "KGN39XW33R", Description = "Blind would equal while oh mr do style. Lain led and fact none. One preferred sportsmen resolving the happiness continued."},
                new CatalogItem(){Id = 22, BrandId = 6, ItemTypeId = 1, Price = (decimal)98.5, Model = "KGN39AI2AR", Description = "High at of in loud rich true. Oh conveying do immediate acuteness in he. Equally welcome her set nothing has gravity whether parties."}
            });
        }
    }
}
using GoodsStore.Core.Domain.Entities.Goods.HouseholdEquipment;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.DataAccess.Mapping.Goods.HouseholdEquipment
{
    public class RefrigeratorMap : CatalogItemConfig<Refrigerator>
    {
        public override void Configure(EntityTypeBuilder<Refrigerator> builder)
        {

            base.Configure(builder);

            builder.HasData(new[]
            {
                new Refrigerator(){Id = 1, BrandId = 5, ItemTypeId = 1, Price = (decimal)12.25, Name = "XM 4208-000", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", Height = 10, Width = 5, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 20},
                new Refrigerator(){Id = 2, BrandId = 5, ItemTypeId = 1, Price = (decimal)89.25, Name = "XM 4215-000", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", Height = 10, Width = 6, FreezerCameraVolume = 12, RefrigeratorCameraVolume = 25 },
                new Refrigerator(){Id = 3, BrandId = 5, ItemTypeId = 1, Price = (decimal)124.145, Name = "XM 4307-001", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium", Height = 12, Width = 7, FreezerCameraVolume = 20, RefrigeratorCameraVolume = 22},
                new Refrigerator(){Id = 4, BrandId = 4, ItemTypeId = 1, Price = (decimal)142.125, Name = "GA-B429SMQZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", Height = 15, Width = 4, FreezerCameraVolume = 30, RefrigeratorCameraVolume = 29},
                new Refrigerator(){Id = 5, BrandId = 4, ItemTypeId = 1, Price = (decimal)1110.25, Name = "GW-B499SMFZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", Height = 8, Width = 8, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 20},
                new Refrigerator(){Id = 6, BrandId = 4, ItemTypeId = 1, Price = (decimal)1210.2, Name = "GA-B499YMQZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising", Height = 15, Width = 5, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 10, BrandId = 1, ItemTypeId = 1, Price = (decimal)142, Name = "RB33J3200SA", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising"},
                new Refrigerator(){Id = 11, BrandId = 1, ItemTypeId = 1, Price = (decimal)578, Name = "RS55K50A02C", Description = "So perhaps, you've generated some fancy text, and you're content that you can now copy and paste"},
                new Refrigerator(){Id = 12, BrandId = 1, ItemTypeId = 1, Price = (decimal)74.25, Name = "RT22HAR4DSA", Description = "Is it some sort of hack? Are you copying and pasting an actual font?"},
                new Refrigerator(){Id = 13, BrandId = 1, ItemTypeId = 1, Price = (decimal)125.12, Name = "RB34N5061B1/WT", Description = "Sudden she seeing garret far regard. By hardly it direct if pretty up regret."},
                new Refrigerator(){Id = 14, BrandId = 1, ItemTypeId = 1, Price = (decimal)111.1, Name = "RB37J5441SA", Description = "Ability thought enquire settled prudent you sir."},
                new Refrigerator(){Id = 15, BrandId = 1, ItemTypeId = 1, Price = (decimal)794.2, Name = "RS54N3003WW/WT", Description = "Or easy knew sold on well come year. Something consulted age extremely end procuring."},
                new Refrigerator(){Id = 16, BrandId = 1, ItemTypeId = 1, Price = (decimal)541.1, Name = "RB37J5000SA", Description = "Collecting preference he inquietude projection me in by."},
                new Refrigerator(){Id = 17, BrandId = 1, ItemTypeId = 1, Price = (decimal)999.99, Name = "RB37J5240SS", Description = "So do of sufficient projecting an thoroughly uncommonly prosperous conviction."},
                new Refrigerator(){Id = 18, BrandId = 6, ItemTypeId = 1, Price = (decimal)231.1, Name = "KGN39XL2AR", Description = "Betrayed cheerful declared end and."},
                new Refrigerator(){Id = 19, BrandId = 6, ItemTypeId = 1, Price = (decimal)452.1, Name = "KGN39XW2AR", Description = "Questions we additions is extremely incommode. Next half add call them eat face."},
                new Refrigerator(){Id = 20, BrandId = 6, ItemTypeId = 1, Price = (decimal)123.1, Name = "KGN39AI31R", Description = "Age lived smile six defer bed their few. Had admitting concluded too behaviour him she."},
                new Refrigerator(){Id = 21, BrandId = 6, ItemTypeId = 1, Price = (decimal)542.4, Name = "KGN39XW33R", Description = "Blind would equal while oh mr do style. Lain led and fact none. One preferred sportsmen resolving the happiness continued."},
                new Refrigerator(){Id = 22, BrandId = 6, ItemTypeId = 1, Price = (decimal)98.5, Name = "KGN39AI2AR", Description = "High at of in loud rich true. Oh conveying do immediate acuteness in he. Equally welcome her set nothing has gravity whether parties."}
            });
        }
    }
}
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
                new Refrigerator(){Id = 1, BrandId = 5, ItemTypeId = 1, Price = (decimal)12.25, Name = "XM 4208-000", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                    Height = 10, Width = 5, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 20},
                new Refrigerator(){Id = 2, BrandId = 5, ItemTypeId = 1, Price = (decimal)89.25, Name = "XM 4215-000", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                    Height = 10, Width = 6, FreezerCameraVolume = 12, RefrigeratorCameraVolume = 25 },
                new Refrigerator(){Id = 3, BrandId = 5, ItemTypeId = 1, Price = (decimal)124.145, Name = "XM 4307-001", Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                    Height = 12, Width = 7, FreezerCameraVolume = 20, RefrigeratorCameraVolume = 22},
                new Refrigerator(){Id = 4, BrandId = 4, ItemTypeId = 1, Price = (decimal)142.125, Name = "GA-B429SMQZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                    Height = 15, Width = 4, FreezerCameraVolume = 30, RefrigeratorCameraVolume = 29},
                new Refrigerator(){Id = 5, BrandId = 4, ItemTypeId = 1, Price = (decimal)1110.25, Name = "GW-B499SMFZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                    Height = 8, Width = 8, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 20},
                new Refrigerator(){Id = 6, BrandId = 4, ItemTypeId = 1, Price = (decimal)1210.2, Name = "GA-B499YMQZ", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                    Height = 16, Width = 1, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 10, BrandId = 1, ItemTypeId = 1, Price = (decimal)142, Name = "RB33J3200SA", Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                    Height = 20, Width = 2, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 11, BrandId = 1, ItemTypeId = 1, Price = (decimal)578, Name = "RS55K50A02C", Description = "So perhaps, you've generated some fancy text, and you're content that you can now copy and paste",
                    Height = 15, Width = 3, FreezerCameraVolume = 25, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 12, BrandId = 1, ItemTypeId = 1, Price = (decimal)74.25, Name = "RT22HAR4DSA", Description = "Is it some sort of hack? Are you copying and pasting an actual font?",
                    Height = 5, Width = 4, FreezerCameraVolume = 13, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 13, BrandId = 1, ItemTypeId = 1, Price = (decimal)125.12, Name = "RB34N5061B1/WT", Description = "Sudden she seeing garret far regard. By hardly it direct if pretty up regret.",
                    Height = 4, Width = 5, FreezerCameraVolume = 12, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 14, BrandId = 1, ItemTypeId = 1, Price = (decimal)111.1, Name = "RB37J5441SA", Description = "Ability thought enquire settled prudent you sir.",
                    Height = 15, Width = 5.1, FreezerCameraVolume = 12, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 15, BrandId = 1, ItemTypeId = 1, Price = (decimal)794.2, Name = "RS54N3003WW/WT", Description = "Or easy knew sold on well come year. Something consulted age extremely end procuring.",
                    Height = 15, Width = 5.2, FreezerCameraVolume = 11, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 16, BrandId = 1, ItemTypeId = 1, Price = (decimal)541.1, Name = "RB37J5000SA", Description = "Collecting preference he inquietude projection me in by.",
                    Height = 6, Width = 5.3, FreezerCameraVolume = 10, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 17, BrandId = 1, ItemTypeId = 1, Price = (decimal)999.99, Name = "RB37J5240SS", Description = "So do of sufficient projecting an thoroughly uncommonly prosperous conviction.",
                    Height = 11, Width = 5.4, FreezerCameraVolume = 9, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 18, BrandId = 6, ItemTypeId = 1, Price = (decimal)231.1, Name = "KGN39XL2AR", Description = "Betrayed cheerful declared end and.",
                    Height = 41.41, Width = 5.5, FreezerCameraVolume = 8, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 19, BrandId = 6, ItemTypeId = 1, Price = (decimal)452.1, Name = "KGN39XW2AR", Description = "Questions we additions is extremely incommode. Next half add call them eat face.",
                    Height = 3.45, Width = 5.6, FreezerCameraVolume = 7, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 20, BrandId = 6, ItemTypeId = 1, Price = (decimal)123.1, Name = "KGN39AI31R", Description = "Age lived smile six defer bed their few. Had admitting concluded too behaviour him she.",
                    Height = 4, Width = 5.7, FreezerCameraVolume = 6, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 21, BrandId = 6, ItemTypeId = 1, Price = (decimal)542.4, Name = "KGN39XW33R", Description = "Blind would equal while oh mr do style. Lain led and fact none. One preferred sportsmen resolving the happiness continued.",
                    Height = 13, Width = 5.8, FreezerCameraVolume = 5, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 22, BrandId = 3, ItemTypeId = 1, Price = (decimal)98.5, Name = "KGN39AI2AR", Description = "High at of in loud rich true. Oh conveying do immediate acuteness in he. Equally welcome her set nothing has gravity whether parties.",
                    Height = 9.52, Width = 5.9, FreezerCameraVolume = 4, RefrigeratorCameraVolume = 21},
                new Refrigerator(){Id = 23, BrandId = 3, ItemTypeId = 1, Price = (decimal)9432.1, Name = "XY135468", Description = "Age lived smile six defer bed their few. Had admitting concluded too behaviour him she.",
                    Height = 4.25, Width = 5, FreezerCameraVolume = 3, RefrigeratorCameraVolume = 33},
                new Refrigerator(){Id = 24, BrandId = 3, ItemTypeId = 1, Price = (decimal)10.11, Name = "XR498731", Description = "Blind would equal while oh mr do style. Lain led and fact none. One preferred sportsmen resolving the happiness continued.",
                    Height = 24.1, Width = 5, FreezerCameraVolume = 2, RefrigeratorCameraVolume = 23},
                new Refrigerator(){Id = 25, BrandId = 3, ItemTypeId = 1, Price = (decimal)98.5, Name = "XF46568", Description = "High at of in loud rich true. Oh conveying do immediate acuteness in he. Equally welcome her set nothing has gravity whether parties.",
                    Height = 4, Width = 5, FreezerCameraVolume = 1.89, RefrigeratorCameraVolume = 13}
            });
        }
    }
}
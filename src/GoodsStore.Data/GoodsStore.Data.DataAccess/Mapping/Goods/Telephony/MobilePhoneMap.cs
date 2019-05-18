using GoodsStore.Core.Entities.Goods.Telephony;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.DataAccess.Mapping.Goods.Telephony
{
    public class MobilePhoneMap : CatalogItemConfig<MobilePhone>
    {
        public override void Configure(EntityTypeBuilder<MobilePhone> builder)
        {
            base.Configure(builder);

            builder.HasData(new []
            {
                new MobilePhone(){Id = 1001, BrandId = 4, ItemTypeId = 3, Price = (decimal)12.25, Name = "V30S+ ThinQ Gray", Description = "Li Europan lingues es membres del sam familie. Lor separat existentie es un myth."},
                new MobilePhone(){Id = 1002, BrandId = 4, ItemTypeId = 3, Price = (decimal)782.25, Name = "G360", Description = "Por scientie, musica, sport etc, litot Europa usa li sam vocabular."},
                new MobilePhone(){Id = 1003, BrandId = 4, ItemTypeId = 3, Price = (decimal)152.25, Name = "V40 ThinQ 64Gb Black", Description = " Li lingues differe solmen in li grammatica, li pronunciation e li plu commun vocabules."},

            });
        }
    }
}
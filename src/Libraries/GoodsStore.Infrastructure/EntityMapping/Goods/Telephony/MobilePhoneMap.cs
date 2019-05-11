using GoodsStore.Core.Entities.Goods.Telephony;
using GoodsStore.Infrastructure.MappingBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Infrastructure.EntityMapping.Goods.Telephony
{
    public class MobilePhoneMap : ProductEntityConfig<MobilePhone>
    {
        public override void Configure(EntityTypeBuilder<MobilePhone> builder)
        {
            builder.ToTable("MobilePhones");
            builder.HasKey(r => r.Id);
            base.Configure(builder);

            builder.HasData(new MobilePhone[]
            {
                new MobilePhone(){Id = 1, CatalogItemId = 7},
                new MobilePhone(){Id = 2, CatalogItemId = 7},
                new MobilePhone(){Id = 3, CatalogItemId = 7},

            });
        }
    }
}
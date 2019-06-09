using GoodsStore.Core.Domain.Entities.BasketAggregate;
using GoodsStore.Core.Domain.Entities.Helpers;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.DataAccess.Mapping.BasketAggregate
{
    public class BasketItemMap : BaseConfig<BasketItem>
    {
        public override void Configure(EntityTypeBuilder<BasketItem> builder)
        {
            builder.ToTable("BasketItems");
            builder.HasKey(bi => bi.Id);
            builder.Property(bi => bi.Discriminator)
                .IsRequired();
        }
    }
}
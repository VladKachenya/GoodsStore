using GoodsStore.Core.Domain.Entities.ComparisonBasketAggregate;
using GoodsStore.Core.Domain.Entities.Helpers;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.DataAccess.Mapping.BasketAggregate
{
    public class ComparisonBasketItemMap : BaseConfig<ComparisonBasketItem>
    {
        public override void Configure(EntityTypeBuilder<ComparisonBasketItem> builder)
        {
            //builder.ToTable("ComparisonBasketItem");
            builder.HasKey(bi => bi.Id);
            builder.Property(bi => bi.Discriminator)
                .IsRequired();
        }
    }
}
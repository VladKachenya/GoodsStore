using GoodsStore.Core.Domain.Entities.ComparisonBasketAggregate;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.DataAccess.Mapping.BasketAggregate
{
    public class ComparisonBasketMap : BaseConfig<ComparisonBasket>
    {
        public override void Configure(EntityTypeBuilder<ComparisonBasket> builder)
        {
            //builder.ToTable("ComparisonBasket");
            builder.HasKey(bi => bi.Id);
            builder.HasMany(i => i.Items).WithOne(b => b.ComparisonBasket).OnDelete(DeleteBehavior.Cascade);

            var navigation = builder.Metadata.FindNavigation(nameof(ComparisonBasket.Items));

            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}
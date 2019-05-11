using GoodsStore.Infrastructure.Mapping;
using GoodsStore.Section.HouseholdAppliances.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Section.HouseholdAppliances.Data.Mapping
{
    public class SomeEntityMap : GoodsStoreEntityTypeConfiguration<SomeEntity>
    {
        public override void Configure(EntityTypeBuilder<SomeEntity> builder)
        {
            builder.ToTable("SomeEntities");
            builder.Property(p => p.SomeEntityName).IsRequired().HasMaxLength(30);
        }
    }
}
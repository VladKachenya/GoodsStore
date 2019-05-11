using GoodsStore.Core.Entities;
using GoodsStore.Infrastructure.MappingBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Infrastructure.EntityMapping
{
    public class CategoryMap : EntityConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(c => c.Id);
            builder.HasMany(c => c.ItemTypes).WithOne(i => i.Category);
            builder.HasData(new Category[]
            {
                new Category(){Id = 1, CategoryName = "Household equipment"},
                new Category(){Id = 2, CategoryName = "Telephony"},
            });
        }
    }
}
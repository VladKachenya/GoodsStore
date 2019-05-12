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
                new Category(){Id = 3, CategoryName = "Chancellery"},
                new Category(){Id = 4, CategoryName = "Сhildren's world"},
                new Category(){Id = 5, CategoryName = "Computers"},
                new Category(){Id = 6, CategoryName = "Health and beauty"},
                new Category(){Id = 7, CategoryName = "Furniture and interior"},
                new Category(){Id = 8, CategoryName = "Sport and tourism"}
            });
        }
    }
}
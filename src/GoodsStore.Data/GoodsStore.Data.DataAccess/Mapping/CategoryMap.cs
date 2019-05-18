using GoodsStore.Core.Entities;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.DataAccess.Mapping
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
                new Category(){Id = 1, Name = "Household equipment"},
                new Category(){Id = 2, Name = "Telephony"},
                new Category(){Id = 3, Name = "Chancellery"},
                new Category(){Id = 4, Name = "Сhildren's world"},
                new Category(){Id = 5, Name = "Computers"},
                new Category(){Id = 6, Name = "Health and beauty"},
                new Category(){Id = 7, Name = "Furniture and interior"},
                new Category(){Id = 8, Name = "Sport and tourism"}
            });
        }
    }
}
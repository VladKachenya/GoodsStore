using GoodsStore.Core.Entities;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.DataAccess.Mapping
{
    public class ItemTypeMap : EntityConfig<ItemType>
    {
        public override void Configure(EntityTypeBuilder<ItemType> builder)
        {
            builder.ToTable("ItemTypes");
            builder.Property(p => p.TypeName).IsRequired().HasMaxLength(30);

            builder.HasOne(i => i.Category).WithMany(c => c.ItemTypes).HasForeignKey(i => i.CategoryId).IsRequired();
            builder.HasData(new ItemType[]
            {
                new ItemType(){Id = 1, CategoryId = 1, TypeName = "Refrigerators", UnitName = "Refrigerator"},
                new ItemType(){Id = 2, CategoryId = 1, TypeName = "TVs", UnitName = "TV"},
                new ItemType(){Id = 3, CategoryId = 2, TypeName = "Mobile phones", UnitName = "Mobile phone"},
                new ItemType(){Id = 4, CategoryId = 2, TypeName = "Phone cases", UnitName = "Case"},
                new ItemType(){Id = 5, CategoryId = 1, TypeName = "Blenders", UnitName = "Blender"},

            });
        }
    }
}
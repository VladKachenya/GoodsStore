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
                new ItemType(){Id = 1, CategoryId = 1, TypeName = "Large appliances for kitchen"},
                new ItemType(){Id = 2, CategoryId = 1, TypeName = "Home appliances"},
                new ItemType(){Id = 3, CategoryId = 2, TypeName = "Mobile phone"},
                new ItemType(){Id = 4, CategoryId = 2, TypeName = "Accessories"}
            });
        }
    }
}
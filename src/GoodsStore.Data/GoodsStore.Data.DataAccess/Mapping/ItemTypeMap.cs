using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Goods.HouseholdEquipment;
using GoodsStore.Core.Domain.Entities.Goods.Telephony;
using GoodsStore.Core.Domain.Keys;
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
            builder.Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Property(p => p.UnitName).IsRequired();


            builder.HasOne(i => i.Category).WithMany(c => c.ItemTypes).HasForeignKey(i => i.CategoryId).IsRequired();
            builder.HasData(new ItemType[]
            {
                new ItemType(){Id = (int)GoodsTypes.Refrigerator, CategoryId = 1, Name = "Refrigerators", UnitName = nameof(Refrigerator)},
                new ItemType(){Id = (int)GoodsTypes.Tv, CategoryId = 1, Name = "TVs", UnitName = "TV"},
                new ItemType(){Id = (int)GoodsTypes.MobilePhone, CategoryId = 2, Name = "Mobile phones", UnitName = nameof(MobilePhone)},
                new ItemType(){Id = (int)GoodsTypes.PhoneCase, CategoryId = 2, Name = "Phone cases", UnitName = "Case"},
                new ItemType(){Id = (int)GoodsTypes.Blender, CategoryId = 1, Name = "Blenders", UnitName = "Blender"},

            });
        }
    }
}
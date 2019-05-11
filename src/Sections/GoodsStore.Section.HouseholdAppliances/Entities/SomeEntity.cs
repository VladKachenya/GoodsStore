using System.Collections.Generic;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Infrastructure.EntityMapping;

namespace GoodsStore.Section.HouseholdAppliances.Entities
{
    public class SomeEntity : BaseEntity
    {
        public string SomeEntityName { get; set; }
        public string SomeEntityData { get; set; }

        public int BrandId { get; set; }
        public List<Brand> Brands { get; set; }

    }
}
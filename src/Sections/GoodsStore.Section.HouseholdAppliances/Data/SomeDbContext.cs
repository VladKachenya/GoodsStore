using GoodsStore.Infrastructure.Data;
using GoodsStore.Section.HouseholdAppliances.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoodsStore.Section.HouseholdAppliances.Data
{
    public class SomeDbContext : GoodsStoreDbContext
    {
        public DbSet<SomeEntity> SomeEntities { get; set; }
    }
}
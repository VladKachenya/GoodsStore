using GoodsStore.Core.Entities;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Core.Keys;
using Microsoft.EntityFrameworkCore;

namespace GoodsStore.Infrastructure.Data
{
    public class CatalogDbContext : DbContext
    {
        //public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options)
        //{
        //}
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<Refrigerator> Refrigerators{ get; set; }

        public DbSet<ItemBrand> Brands { get; set; }
        public DbSet<ItemType> Types { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppKeys.DbConnectionString);
        }
    }
}
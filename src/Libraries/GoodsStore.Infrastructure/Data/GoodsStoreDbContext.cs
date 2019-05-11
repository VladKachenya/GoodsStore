using GoodsStore.Core.Keys;
using GoodsStore.Infrastructure.MappingBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace GoodsStore.Infrastructure.Data
{
    public class GoodsStoreDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppKeys.DbConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Selecting all the types for configuration
            var typeConfigurations = Assembly.GetExecutingAssembly().GetTypes().Where(type =>
                !type.IsAbstract && (type.BaseType?.IsGenericType ?? false)
                && (type.BaseType.GetGenericTypeDefinition() == typeof(EntityConfig<>) ||
                    type.BaseType.GetGenericTypeDefinition() == typeof(ProductEntityConfig<>)));


            foreach (var typeConfiguration in typeConfigurations)
            {
                var configuration = (IMappingConfiguration)Activator.CreateInstance(typeConfiguration);
                configuration.ApplyConfiguration(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
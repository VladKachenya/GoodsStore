using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GoodsStore.Core.AppInfrastructure;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Keys;
using GoodsStore.Infrastructure.EntityMapping;
using GoodsStore.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GoodsStore.Infrastructure.Data
{
    public class GoodsStoreDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppKeys.DbConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var assembly = Assembly.GetAssembly(GetType());
            //var typeConfigurations = assembly.GetTypes().Where(type =>
            //    (type.BaseType?.IsGenericType ?? false)
            //    && (type.BaseType.GetGenericTypeDefinition() == typeof(GoodsStoreEntityTypeConfiguration<>)));
            
            //foreach (var mappingConfiguration in typeConfigurations)
            //{
            //    ((IMappingConfiguration)Activator.CreateInstance(mappingConfiguration)).ApplyConfiguration(modelBuilder);
            //}
        }
    }
}
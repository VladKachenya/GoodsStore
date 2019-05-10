using System;
using System.Collections.Generic;
using System.Linq;
using GoodsStore.Core.AppInfrastructure;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Core.Keys;
using GoodsStore.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

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
            var mappingConfigurations = new List<Type>();
            foreach (var assembly in (new GoodsStoreTypeFinder().GetAssemblies()))
            {
                mappingConfigurations.AddRange(assembly.GetTypes().Where(type =>
                    (type.BaseType?.IsGenericType ?? false)
                    && (type.BaseType.GetGenericTypeDefinition() == typeof(GoodsStoreEntityTypeConfiguration<>))));
            }
            foreach (var mappingConfiguration in mappingConfigurations)
            {
                ((IMappingConfiguration) Activator.CreateInstance(mappingConfiguration)).ApplyConfiguration(modelBuilder);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
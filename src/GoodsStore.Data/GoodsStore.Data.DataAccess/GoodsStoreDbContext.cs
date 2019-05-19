﻿using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Data.Infrastructure.Data;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace GoodsStore.Data.DataAccess
{
    public class GoodsStoreDbContext : DbContext, IDbContext
    {
        public GoodsStoreDbContext(DbContextOptions<GoodsStoreDbContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Selecting all the types for configuration
            var typeConfigurations = Assembly.GetExecutingAssembly().GetTypes().Where(type =>
                !type.IsAbstract && (type.BaseType?.IsGenericType ?? false)
                && (type.BaseType.GetGenericTypeDefinition() == typeof(EntityConfig<>) ||
                    type.BaseType.GetGenericTypeDefinition() == typeof(CatalogItemConfig<>)));


            foreach (var typeConfiguration in typeConfigurations)
            {
                var configuration = (IMappingConfiguration)Activator.CreateInstance(typeConfiguration);
                configuration.ApplyConfiguration(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }


        #region Implementation of IDbContext

        public DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
        #endregion

    }
}
﻿using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Data.Infrastructure.Data;
using GoodsStore.Data.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

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
                    type.BaseType.GetGenericTypeDefinition() == typeof(CatalogItemConfig<>) ||
                    type.BaseType.GetGenericTypeDefinition() == typeof(BaseConfig<>)));

            foreach (var typeConfiguration in typeConfigurations)
            {
                var configuration = (IMappingConfiguration)Activator.CreateInstance(typeConfiguration);
                configuration.ApplyConfiguration(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }


        #region Implementation of IDbContext

        public DbSet<TEntity> Set<TEntity>() where TEntity : BaseData
        {
            return base.Set<TEntity>();
        }

        public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : BaseData
        {
            return base.Entry(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        #endregion

    }
}
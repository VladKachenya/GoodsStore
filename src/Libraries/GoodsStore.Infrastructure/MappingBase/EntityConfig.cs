using System.Linq;
using System.Reflection;
using GoodsStore.Core.AppInfrastructure;
using GoodsStore.Core.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Infrastructure.MappingBase
{
    public abstract class EntityConfig<TEntity> : IMappingConfiguration, IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);

        public void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(this);
        }
    }
}
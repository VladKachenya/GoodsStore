using GoodsStore.Core.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.Infrastructure.Mapping
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
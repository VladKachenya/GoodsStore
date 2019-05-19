using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.Infrastructure.Mapping
{
    public abstract class BaseConfig<TEntity> : IMappingConfiguration, IEntityTypeConfiguration<TEntity> where TEntity : class 
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);

        public void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(this);
        }
    }
}
using GoodsStore.Core.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Infrastructure.MappingBase
{
    public abstract class ProductEntityConfig<TEntity> : EntityConfig<TEntity> where TEntity : ProductBaseEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasOne(r => r.CatalogItem).WithMany().HasForeignKey(r => r.CatalogItemId);
        }
    }
}
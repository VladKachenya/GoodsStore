using GoodsStore.Core.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.Infrastructure.Mapping
{
    public abstract class CatalogItemConfig<TEntity> : EntityConfig<TEntity> where TEntity : CatalogItem
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable("CatalogItems");
        }
    }
}
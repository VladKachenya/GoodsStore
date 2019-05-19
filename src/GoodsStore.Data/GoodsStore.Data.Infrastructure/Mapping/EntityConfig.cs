using GoodsStore.Core.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoodsStore.Data.Infrastructure.Mapping
{
    public abstract class EntityConfig<TEntity> : BaseConfig<TEntity> where TEntity : BaseEntity
    {
    }
}
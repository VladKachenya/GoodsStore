using GoodsStore.Core.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace GoodsStore.Core.Interfaces.Data
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;

    }
}
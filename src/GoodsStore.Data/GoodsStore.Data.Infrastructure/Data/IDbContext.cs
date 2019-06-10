using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GoodsStore.Data.Infrastructure.Data
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : BaseData;

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : BaseData;

        Task<int> SaveChangesAsync();
    }
}
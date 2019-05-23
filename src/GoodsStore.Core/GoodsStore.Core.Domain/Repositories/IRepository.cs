using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Specifications;

namespace GoodsStore.Core.Domain.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> GetById(int id);
        Task<IReadOnlyList<T>> ListAll();
        Task<IReadOnlyList<T>> List(ISpecification<T> spec);
        Task<int> Count(ISpecification<T> spec);
        //Task<T> AddAsync(T entity);
        //Task UpdateAsync(T entity);
        //Task DeleteAsync(T entity);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Specifications;

namespace GoodsStore.Core.Domain.Repositories
{
    public interface IRepository<T> where T : BaseData
    {
        Task<T> GetById(int id);
        Task<T> GetFirstOrDefault(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAll();
        Task<IReadOnlyList<T>> List(ISpecification<T> spec);
        Task<int> Count(ISpecification<T> spec);
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
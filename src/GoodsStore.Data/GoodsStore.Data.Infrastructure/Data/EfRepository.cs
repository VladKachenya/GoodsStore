using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Interfaces.Repositories;
using GoodsStore.Core.Domain.Interfaces.Specifications;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsStore.Data.Infrastructure.Data
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly IDbContext DbContext;
        private readonly ISpecificationEvaluator<TEntity> _specificationEvaluator;


        public EfRepository(IDbContext dbContext, ISpecificationEvaluator<TEntity> specificationEvaluator)
        {
            DbContext = dbContext;
            _specificationEvaluator = specificationEvaluator;
        }

        public async Task<TEntity> GetById(int id)
        {
            return await DbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<IReadOnlyList<TEntity>> ListAll()
        {
            return await DbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<IReadOnlyList<TEntity>> List(ISpecification<TEntity> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<int> Count(ISpecification<TEntity> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        protected IQueryable<TEntity> ApplySpecification(ISpecification<TEntity> spec, IQueryable<TEntity> queryable = null)
        {
            queryable = queryable ?? DbContext.Set<TEntity>().AsQueryable();
            return _specificationEvaluator.GetQuery(queryable, spec);
        }

        //public Task<T> AddAsync(T entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task UpdateAsync(T entity)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public Task DeleteAsync(T entity)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}

using GoodsStore.Core.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;

namespace GoodsStore.Data.Infrastructure.Data
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseData
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

        public async Task<TEntity> GetFirstOrDefault(ISpecification<TEntity> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
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

        public async Task<TEntity> Add(TEntity entity)
        {
            DbContext.Set<TEntity>().Add(entity);
            await DbContext.SaveChangesAsync();

            return entity;
        }

        public async Task Update(TEntity entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            DbContext.Set<TEntity>().Remove(entity);
            await DbContext.SaveChangesAsync();
        }
    }
}

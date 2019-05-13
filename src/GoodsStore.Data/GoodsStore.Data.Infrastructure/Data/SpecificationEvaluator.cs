using System.Linq;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Core.Interfaces.Specifications;

namespace GoodsStore.Data.Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> : ISpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        public IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specification)
        {
            var query = inputQuery;

            // modify the IQueryable using the specification's criteria expression
            if (specification.Criteria != null)
            {
                query = query.Where(specification.Criteria);
            }

            // Apply paging if enabled
            if (specification.IsPagingEnabled)
            {
                query = query.Skip(specification.Skip)
                    .Take(specification.Take);
            }
            return query;
        }
    }
}
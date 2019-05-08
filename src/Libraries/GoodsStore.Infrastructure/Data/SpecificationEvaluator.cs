using GoodsStore.Core.Entities.Base;
using System.Linq;
using GoodsStore.Core.Interfaces.Specifications;

namespace GoodsStore.Infrastructure.Data
{
    public class SpecificationEvaluator<T> where T : BaseEntity
    {
        public IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
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
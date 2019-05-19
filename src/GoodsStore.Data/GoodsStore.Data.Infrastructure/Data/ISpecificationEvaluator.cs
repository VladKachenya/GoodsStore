using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Interfaces.Specifications;
using System.Linq;

namespace GoodsStore.Data.Infrastructure.Data
{
    public interface ISpecificationEvaluator<T> where T : BaseEntity
    {
        IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification);
    }
}
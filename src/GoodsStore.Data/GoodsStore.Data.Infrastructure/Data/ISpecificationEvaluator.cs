using GoodsStore.Core.Domain.Entities.Base;
using System.Linq;
using GoodsStore.Core.Domain.Specifications;

namespace GoodsStore.Data.Infrastructure.Data
{
    public interface ISpecificationEvaluator<T> where T : BaseData
    {
        IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification);
    }
}
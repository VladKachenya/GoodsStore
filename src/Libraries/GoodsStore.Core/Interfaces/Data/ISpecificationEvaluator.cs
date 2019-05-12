using System.Linq;
using GoodsStore.Core.Entities.Base;
using GoodsStore.Core.Interfaces.Specifications;

namespace GoodsStore.Core.Interfaces.Data
{
    public interface ISpecificationEvaluator<T> where T : BaseEntity
    {
        IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification);
    }
}
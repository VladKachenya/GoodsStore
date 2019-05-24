using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Data.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodsStore.Data.DataAccess.Repositories
{
    public class CatalogItemRepository<TCatalogItem> : EfRepository<TCatalogItem>, ICatalogItemRepository<TCatalogItem>, ICatalogItemRepository where TCatalogItem : CatalogItem
    {
        public CatalogItemRepository(IDbContext dbContext, ISpecificationEvaluator<TCatalogItem> specificationEvaluator) : base(dbContext, specificationEvaluator)
        {
        }

        public async Task<IReadOnlyList<CatalogItem>> List(object specification)
        {
            return await base.List(GetSpecification(specification));
        }

        public async Task<int> Count(object specification)
        {
            return await base.Count(GetSpecification(specification));

        }

        #region Utility 
        private ISpecification<TCatalogItem> GetSpecification(object specification)
        {
            if (specification == null)
            {
                throw new ArgumentNullException();
            }

            if (!(specification is ISpecification<TCatalogItem>))
            {
                throw new ArgumentException($"Argument must be the {nameof(ISpecification<TCatalogItem>)} type!");
            }

            return specification as ISpecification<TCatalogItem>;
        }


        #endregion
    }
}
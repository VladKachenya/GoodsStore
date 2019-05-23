using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Data.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;

namespace GoodsStore.Data.DataAccess.Repositories
{
    public class CatalogItemRepository : EfRepository<CatalogItem>, ICatalogItemRepository
    {
        public CatalogItemRepository(IDbContext dbContext, ISpecificationEvaluator<CatalogItem> specificationEvaluator) : base(dbContext, specificationEvaluator)
        {
        }

        public async Task<IReadOnlyList<CatalogItem>> ListIncludesItemTypeAndBrand(ISpecification<CatalogItem> spec)
        {
            var dbQuery = DbContext.Set<CatalogItem>().Include(ci => ci.ItemType).Include(ci => ci.Brand).AsQueryable();
            return await ApplySpecification(spec, dbQuery).ToListAsync();
        }
    }
}
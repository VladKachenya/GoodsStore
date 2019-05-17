using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Interfaces.Repositories;
using GoodsStore.Core.Interfaces.Specifications;
using GoodsStore.Data.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

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
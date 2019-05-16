using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Entities;
using GoodsStore.Core.Interfaces.Repositories;
using GoodsStore.Data.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GoodsStore.Data.DataAccess.Repositories
{
    public class CatalogRepository : EfRepository<Category>, ICatalogRepository
    {
        public CatalogRepository(IDbContext dbContext, ISpecificationEvaluator<Category> specificationEvaluator) : base(dbContext, specificationEvaluator)
        {
        }

        public async Task<IReadOnlyList<Category>> ListAllIncludesCatalogItemsAsync()
        {
            return await DbContext.Set<Category>().Include(c => c.ItemTypes).ToListAsync();
        }
    }
}
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Data.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Repositories;

namespace GoodsStore.Data.DataAccess.Repositories
{
    public class CategoryRepository : EfRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbContext dbContext, ISpecificationEvaluator<Category> specificationEvaluator) : base(dbContext, specificationEvaluator)
        {
        }

        public async Task<IReadOnlyList<Category>> ListAllIncludesCatalogItems()
        {
            return await DbContext.Set<Category>().Include(c => c.ItemTypes).ToListAsync();
        }
    }
}
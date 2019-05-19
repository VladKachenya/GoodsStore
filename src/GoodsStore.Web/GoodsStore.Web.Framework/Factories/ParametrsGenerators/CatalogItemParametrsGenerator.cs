using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Interfaces.Repositories;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;

namespace GoodsStore.Web.Framework.Factories.ParametrsGenerators
{
    public abstract class CatalogItemParametrsGenerator : IParametrsGenerator
    {
        private readonly IRepository<Brand> _brandRepository;
        protected readonly IParametrFactory _parametrFactory;

        protected CatalogItemParametrsGenerator(
            IRepository<Brand> brandRepository,
            IParametrFactory parametrFactory
            )
        {
            _brandRepository = brandRepository;
            _parametrFactory = parametrFactory;
        }
        public virtual string ProductKey => GoodsKeys.CatalogItemKey;
        public async Task<List<IParametr>> GetParametrs()
        {

            return null;
        }
    }
}
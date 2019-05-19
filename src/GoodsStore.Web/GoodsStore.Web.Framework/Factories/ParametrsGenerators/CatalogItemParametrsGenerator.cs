using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Interfaces.Repositories;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;

namespace GoodsStore.Web.Framework.Factories.ParametrsGenerators
{
    public class CatalogItemParametrsGenerator : IParametrsGenerator
    {
        protected readonly IParametrFactory _parametrFactory;

        public CatalogItemParametrsGenerator(
            IParametrFactory parametrFactory)
        {
            _parametrFactory = parametrFactory;
        }
        public virtual GoodsTypes ProductKey => default(GoodsTypes);
        public virtual List<IParametr> GetParametrs(ItemType itemType)
        {
            var res = new List<IParametr>();
            // Тут из базы данных необходимо достовать максиальную и минимальную цену
            res.Add(_parametrFactory.GetRangeParametr(1, 15, "Prise"));
            res.Add(_parametrFactory.GetPhraseParametr("Product name"));
            var brands = itemType.BrandItemTypes.Select(bi => bi.Brand).ToList();
            res.Add(_parametrFactory.GetSelectebleListParametr(brands, "Brands"));
            return res;
        }
    }
}
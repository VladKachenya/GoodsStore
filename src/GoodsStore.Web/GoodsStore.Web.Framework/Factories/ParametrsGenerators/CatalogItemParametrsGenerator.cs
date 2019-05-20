using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Interfaces.Repositories;
using GoodsStore.Core.Domain.Interfaces.Specifications;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;

namespace GoodsStore.Web.Framework.Factories.ParametrsGenerators
{
    public class CatalogItemParametrsGenerator<TCatalogItem> : IParametrsGenerator where TCatalogItem : CatalogItem 
    {
        protected readonly IParametrFactory _parametrFactory;
        protected readonly IRepository<TCatalogItem> _repository;
        protected readonly Func<ISpecification<TCatalogItem>> _spesificatioFunc;

        public CatalogItemParametrsGenerator(
            IParametrFactory parametrFactory,
            IRepository<TCatalogItem> repository,
            Func<ISpecification<TCatalogItem>> spesificatioFunc)
        {
            _parametrFactory = parametrFactory;
            _repository = repository;
            _spesificatioFunc = spesificatioFunc;
        }
        public virtual GoodsTypes ProductKey => default(GoodsTypes);
        public virtual List<IParametr> GetParametrs(ItemType itemType)
        {
            var res = new List<IParametr>();

            // Запрос к БД для получения максимакльной и минимальной цуна
            var maxPriseSpecifikation = _spesificatioFunc.Invoke();
            var minPriseSpecifikation = _spesificatioFunc.Invoke();
            maxPriseSpecifikation.SetOrder(ci => ci.Price, true).ApplyPaging(0, 1);
            minPriseSpecifikation.SetOrder(ci => ci.Price).ApplyPaging(0, 1); ;
            Task<IReadOnlyList<TCatalogItem>>[] taskc = 
            {
                _repository.List(minPriseSpecifikation),
                _repository.List(maxPriseSpecifikation)
            };
            Task.WhenAll(taskc);
            var minMaxPrise = taskc.Select(t => t.Result.FirstOrDefault()?.Price).ToList();


            res.Add(_parametrFactory.GetRangeParametr((double)minMaxPrise[0], (double)minMaxPrise[1], "Prise"));
            res.Add(_parametrFactory.GetPhraseParametr("Product name"));
            var brands = itemType.BrandItemTypes.Select(bi => bi.Brand).ToList();
            res.Add(_parametrFactory.GetSelectebleListParametr(brands, "Brands"));
            return res;
        }
    }
}
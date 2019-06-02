using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;
using GoodsStore.Web.Framework.Interfaces.Factories;
using GoodsStore.Web.Framework.Interfaces.Model;

namespace GoodsStore.Web.Framework.Factories
{
    public class BaseCatalogItemParametrsGenerator<TCatalogItem> : IParametrsGenerator where TCatalogItem : CatalogItem
    {
        protected readonly IParametrFactory _parametrFactory;
        protected readonly IRepository<TCatalogItem> _repository;
        protected readonly Func<ISpecification<TCatalogItem>> _spesificatioFunc;

        public BaseCatalogItemParametrsGenerator(
            IParametrFactory parametrFactory,
            IRepository<TCatalogItem> repository,
            Func<ISpecification<TCatalogItem>> spesificatioFunc)
        {
            _parametrFactory = parametrFactory;
            _repository = repository;
            _spesificatioFunc = spesificatioFunc;
        }
        public virtual string GoodsKey => nameof(CatalogItem);

        public virtual List<IFilterParametr> GetParametrs(ItemType itemType)
        {
            var res = new List<IFilterParametr>();
            var minMaxPrice = GetEntitiesWithMinMaxValOf(ci => ci.Price);

            res.Add(_parametrFactory.GetRangeParametr(
                (double)minMaxPrice.Item1.Price,
                (double)minMaxPrice.Item2.Price,
                $"Prise, {string.Empty:C0}",
                nameof(CatalogItem.Price)));

            res.Add(_parametrFactory.GetPhraseParametr("Product name", nameof(CatalogItem.Name)));

            res.Add(_parametrFactory.GetPhraseParametr("Some property", "SomeProperty"));


            var brands = itemType.BrandItemTypes.Select(bi => bi.Brand).ToList();
            res.Add(_parametrFactory.GetSelectebleListParametr(brands, "Brands", nameof(CatalogItem.BrandId)));

            return res;
        }

        #region utiletes
        protected (TCatalogItem, TCatalogItem) GetEntitiesWithMinMaxValOf(Expression<Func<TCatalogItem, object>> parametrExpression)
        {
            // Async query to  database for get min and max price
            var maxPriseSpecifikation = _spesificatioFunc.Invoke();
            var minPriseSpecifikation = _spesificatioFunc.Invoke();
            maxPriseSpecifikation.SetOrderingByDescending(parametrExpression).ApplyPaging(0, 1);
            minPriseSpecifikation.SetOrderingBy(parametrExpression).ApplyPaging(0, 1);
            Task<IReadOnlyList<TCatalogItem>>[] taskc =
            {
                _repository.List(minPriseSpecifikation),
                _repository.List(maxPriseSpecifikation)
            };
            Task.WhenAll(taskc);
            var minMaxPrise = taskc.Select(t => t.Result.FirstOrDefault()).ToList();

            return (minMaxPrise[0], minMaxPrise[1]);
        }
        #endregion

    }
}
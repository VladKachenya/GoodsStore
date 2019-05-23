using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Repositories;
using GoodsStore.Core.Domain.Specifications;

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
            var minMaxPrice = GetEntitiesWithMinMaxValOf(ci => ci.Price);

            res.Add(_parametrFactory.GetRangeParametr(
                (double)minMaxPrice.Item1.Price,
                (double)minMaxPrice.Item2.Price,
                $"Prise, {string.Empty:C0}",
                nameof(CatalogItem.Price)));

            res.Add(_parametrFactory.GetPhraseParametr("Product name", nameof(CatalogItem.Name)));

            res.Add(_parametrFactory.GetPhraseParametr("Some property", "SomeProperty"));


            var brands = itemType.BrandItemTypes.Select(bi => bi.Brand).ToList();
            res.Add(_parametrFactory.GetSelectebleListParametr(brands, "Brands", nameof(CatalogItem.Brand)));

            return res;
        }

        #region utiletes
        protected (TCatalogItem, TCatalogItem) GetEntitiesWithMinMaxValOf(Expression<Func<TCatalogItem, object>> parametrExpression)
        {
            // Async query to  database for get min and max price
            var maxPriseSpecifikation = _spesificatioFunc.Invoke();
            var minPriseSpecifikation = _spesificatioFunc.Invoke();
            maxPriseSpecifikation.SetOrder(parametrExpression, true).ApplyPaging(0, 1);
            minPriseSpecifikation.SetOrder(parametrExpression).ApplyPaging(0, 1);
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
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Infrastructure.Model;
using System.Collections.Generic;

namespace GoodsStore.Web.Infrastructure.Factories
{
    public interface IParametrFactory
    {
        IParametr GetSelectebleListParametr(IEnumerable<BaseEntity> baseEntities,
            string parametName, string propertyName);

        IParametr GetPhraseParametr(string parametName, string propertyName);
        IParametr GetRangeParametr(double from, double to, string parametName, string propertyName);
    }
}
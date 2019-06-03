using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Framework.Interfaces.Model;

namespace GoodsStore.Web.Framework.Interfaces.Factories
{
    public interface IParametrFactory
    {
        IFilterParametr GetSelectebleListParametr(IEnumerable<BaseEntity> baseEntities,
            string parametName, string propertyName);

        IFilterParametr GetPhraseParametr(string parametName, string propertyName);
        IFilterParametr GetRangeParametr(double from, double to, string parametName, string propertyName, string dimension = null);
    }
}
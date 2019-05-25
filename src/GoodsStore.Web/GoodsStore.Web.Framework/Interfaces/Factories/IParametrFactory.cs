using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Framework.Interfaces.Model;

namespace GoodsStore.Web.Framework.Interfaces.Factories
{
    public interface IParametrFactory
    {
        IParametr GetSelectebleListParametr(IEnumerable<BaseEntity> baseEntities,
            string parametName, string propertyName);

        IParametr GetPhraseParametr(string parametName, string propertyName);
        IParametr GetRangeParametr(double from, double to, string parametName, string propertyName);
    }
}
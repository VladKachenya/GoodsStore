using System.Collections.Generic;

namespace GoodsStore.Web.Framework.Interfaces.Converters
{
    public interface IConverter<TFrom, TTo>
    {
        TTo Convert(TFrom obj);

        IEnumerable<TTo> ConvertRang(IEnumerable<TFrom> objs);
    }
}
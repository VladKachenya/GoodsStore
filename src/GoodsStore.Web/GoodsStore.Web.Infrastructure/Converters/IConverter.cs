using System.Collections.Generic;

namespace GoodsStore.Web.Infrastructure.Converters
{
    public interface IConverter<TFrom, TTo>
    {
        TTo Convert(TFrom obj);

        IEnumerable<TTo> ConvertRang(IEnumerable<TFrom> objs);
    }
}
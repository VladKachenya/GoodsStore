using System.Collections.Generic;
using GoodsStore.Web.Infrastructure.Converters;

namespace GoodsStore.Web.Framework.Converters
{
    public abstract class BaseConverter<TFrom, TTo> : IConverter<TFrom, TTo> 
    {
        public abstract TTo Convert(TFrom obj);
       

        public IEnumerable<TTo> ConvertRang(IEnumerable<TFrom> objs)
        {
            var res = new List<TTo>();
            foreach (var obj in objs)
            {
                res.Add(Convert(obj));
            }
            return res;
        }
    }
}
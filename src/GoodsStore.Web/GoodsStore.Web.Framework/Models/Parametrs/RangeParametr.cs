using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.Framework.Models.Parametrs
{
    public class RangeParametr : BaseEntityParametr, IRangeParametr
    {
        public RangeParametr() : base(ParametrKeys.RangeParametr)
        {
        }

        public double FromValue { get; set; }
        public double ToValue { get; set; }
    }
}
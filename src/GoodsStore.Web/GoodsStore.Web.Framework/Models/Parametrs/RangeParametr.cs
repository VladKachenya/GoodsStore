using GoodsStore.Web.Infrastructure.Constants;
using GoodsStore.Web.Infrastructure.Model;

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
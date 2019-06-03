using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.Framework.Models.FilterParametrs
{
    public class RangeFilterParametr : BaseFilterParametr, IRangeFilterParametr
    {
        public RangeFilterParametr() : base(FilterParametr.RangeParametr)
        {
        }

        public double FromValue { get; set; }
        public double ToValue { get; set; }
        public string Dimension { get; set; }

    }
}
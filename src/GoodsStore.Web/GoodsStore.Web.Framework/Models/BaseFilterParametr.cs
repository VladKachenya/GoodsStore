using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.Framework.Models
{
    public abstract class BaseFilterParametr : IFilterParametr
    {
        protected BaseFilterParametr(FilterParametr filterParametr)
        {
            FilterParametr = filterParametr;
        }

        public string PublicName { get; set; }
        public string ItemPropertyName { get; set; }
        public FilterParametr FilterParametr { get; }
    }
}
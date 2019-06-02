using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.Framework.Interfaces.Model
{
    public interface IFilterParametr
    {
        string PublicName { get; set; }
        string ItemPropertyName { get; set; }

        FilterParametr FilterParametr { get; }
    }
}
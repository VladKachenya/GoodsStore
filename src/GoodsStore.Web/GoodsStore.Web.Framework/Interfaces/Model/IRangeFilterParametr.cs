namespace GoodsStore.Web.Framework.Interfaces.Model
{
    public interface IRangeFilterParametr : IFilterParametr
    {
        double FromValue { get; set; }
        double ToValue { get; set; }
    }
}
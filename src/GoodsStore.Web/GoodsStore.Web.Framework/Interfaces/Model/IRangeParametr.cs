namespace GoodsStore.Web.Framework.Interfaces.Model
{
    public interface IRangeParametr : IParametr
    {
        double FromValue { get; set; }
        double ToValue { get; set; }
    }
}
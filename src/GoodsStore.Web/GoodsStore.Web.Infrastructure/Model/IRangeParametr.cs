namespace GoodsStore.Web.Infrastructure.Model
{
    public interface IRangeParametr : IParametr
    {
        double FromValue { get; set; }
        double ToValue { get; set; }
    }
}
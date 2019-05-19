using GoodsStore.Web.Infrastructure.Constants;

namespace GoodsStore.Web.Infrastructure.Model
{
    public interface IParametr
    {
        string ParametrName { get; set; }
        ParametrKeys ParametrKey { get; }
    }
}
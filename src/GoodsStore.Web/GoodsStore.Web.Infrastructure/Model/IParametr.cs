using GoodsStore.Web.Infrastructure.Constants;

namespace GoodsStore.Web.Infrastructure.Model
{
    public interface IParametr
    {
        string PublicName { get; set; }
        string ItemPropertyName { get; set; }

        ParametrKeys ParametrKey { get; }
    }
}
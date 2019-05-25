using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.Framework.Interfaces.Model
{
    public interface IParametr
    {
        string PublicName { get; set; }
        string ItemPropertyName { get; set; }

        ParametrKeys ParametrKey { get; }
    }
}
using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.Framework.Models
{
    public abstract class BaseEntityParametr : IParametr
    {
        protected BaseEntityParametr(ParametrKeys parametrKey)
        {
            ParametrKey = parametrKey;
        }

        public string PublicName { get; set; }
        public string ItemPropertyName { get; set; }
        public ParametrKeys ParametrKey { get; }
    }
}
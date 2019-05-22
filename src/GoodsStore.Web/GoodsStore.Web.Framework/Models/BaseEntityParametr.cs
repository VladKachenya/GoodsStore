using GoodsStore.Web.Infrastructure.Constants;
using GoodsStore.Web.Infrastructure.Model;

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
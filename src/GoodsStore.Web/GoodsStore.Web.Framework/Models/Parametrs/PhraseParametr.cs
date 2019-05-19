using GoodsStore.Web.Infrastructure.Constants;
using GoodsStore.Web.Infrastructure.Model;

namespace GoodsStore.Web.Framework.Models.Parametrs
{
    public class PhraseParametr : BaseEntityParametr, IPhraseParametr
    {
        public PhraseParametr() : base(ParametrKeys.PhraseParametr)
        {
        }

        public string Phrase { get; set; }
    }
}

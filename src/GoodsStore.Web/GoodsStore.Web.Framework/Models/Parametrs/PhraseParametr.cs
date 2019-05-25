using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Keys;

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

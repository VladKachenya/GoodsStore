using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.Framework.Models.FilterParametrs
{
    public class PhraseFilterParametr : BaseFilterParametr, IPhraseFilterParametr
    {
        public PhraseFilterParametr() : base(FilterParametr.PhraseParametr)
        {
        }

        public string Phrase { get; set; }
    }
}

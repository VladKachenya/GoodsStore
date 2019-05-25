using GoodsStore.Web.Framework.Interfaces.Model;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Components
{
    public class PhraseParametrViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IParametr parametr)
        {
            return View(parametr as IPhraseParametr);
        }
    }
}
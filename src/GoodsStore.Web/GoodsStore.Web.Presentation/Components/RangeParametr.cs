using GoodsStore.Web.Infrastructure.Model;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Components
{
    public class RangeParametrViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IParametr parametr)
        {
            return View(parametr as IRangeParametr);
        }
    }
}
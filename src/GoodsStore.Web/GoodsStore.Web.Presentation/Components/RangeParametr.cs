using GoodsStore.Web.Framework.Interfaces.Model;
using Microsoft.AspNetCore.Mvc;

namespace GoodsStore.Web.Presentation.Components
{
    public class RangeParametrViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IFilterParametr filterParametr)
        {
            return View(filterParametr as IRangeFilterParametr);
        }
    }
}
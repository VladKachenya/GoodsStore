using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoodsStore.Web.Framework.Interfaces.Model
{
    public interface ISelectableListFilterParametr : IFilterParametr
    {
        List<SelectListItem> SelectListItems { get; }
    }
}
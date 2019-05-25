using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoodsStore.Web.Framework.Interfaces.Model
{
    public interface ISelectableListParametr : IParametr
    {
        List<SelectListItem> SelectListItems { get; }
    }
}
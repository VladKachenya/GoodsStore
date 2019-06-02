using System.Collections.Generic;
using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Keys;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoodsStore.Web.Framework.Models.FilterParametrs
{
    public class SelectableListFilterParametr : BaseFilterParametr, ISelectableListFilterParametr
    {
        public SelectableListFilterParametr() : base(FilterParametr.SelectableListParametr)
        {
            SelectListItems = new List<SelectListItem>();
        }

        public List<SelectListItem> SelectListItems { get; }
    }
}
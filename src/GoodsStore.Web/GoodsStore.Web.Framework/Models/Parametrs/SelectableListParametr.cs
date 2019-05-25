using System.Collections.Generic;
using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Keys;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoodsStore.Web.Framework.Models.Parametrs
{
    public class SelectableListParametr : BaseEntityParametr, ISelectableListParametr
    {
        public SelectableListParametr() : base(ParametrKeys.SelectableListParametr)
        {
            SelectListItems = new List<SelectListItem>();
        }

        public List<SelectListItem> SelectListItems { get; }
    }
}
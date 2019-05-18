using System.Collections.Generic;
using GoodsStore.Web.Infrastructure.Constants;
using GoodsStore.Web.Infrastructure.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoodsStore.Web.Framework.Models.Parametrs
{
    public class SelectableListParametr : BaseEntityParametr, ISelectableListParametr
    {
        public SelectableListParametr() : base(ParametrKeys.SelectableList)
        {
            SelectListItems = new List<SelectListItem>();
        }

        public List<SelectListItem> SelectListItems { get; }
    }
}
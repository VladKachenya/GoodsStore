using System.Collections.Generic;
using GoodsStore.Web.Framework.Interfaces.Model;

namespace GoodsStore.Web.ViewModel.Models.CompositModels
{
    public class GoodsIndexModel
    {
        public string TypeName { get; set; }
        public string TypeDiscriminator { get; set; }

        public List<IFilterParametr> Parametrs { get; set; } 
    }
}
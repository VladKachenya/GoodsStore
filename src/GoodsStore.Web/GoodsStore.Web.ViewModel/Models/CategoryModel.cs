using System.Collections.Generic;
using GoodsStore.Web.Framework.Models;

namespace GoodsStore.Web.ViewModel.Models
{
    public class CategoryModel : BaseEntityModel
    {
        public IEnumerable<ItemTypeModel> ItemTypeModels { get; set; }
        public string CategoryName { get; set; }
        public string IconName { get; set; }
    }
}
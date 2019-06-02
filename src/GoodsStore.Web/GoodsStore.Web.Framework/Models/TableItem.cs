using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.Framework.Models
{
    public class TableItem : ITableItem
    {
        public string Title { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public TableItemType ItemType { get; set; }
    }
}
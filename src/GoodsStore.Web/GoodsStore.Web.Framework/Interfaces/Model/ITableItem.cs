using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.Framework.Interfaces.Model
{
    public interface ITableItem
    {
        string Title { get; set; }
        string Value { get; set; }
        string Description { get; set; }
        TableItemType ItemType { get; set; }
    }
}
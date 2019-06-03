using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Web.Framework.Interfaces.Factories;
using GoodsStore.Web.Framework.Interfaces.Model;
using System;
using System.Collections.Generic;
using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.Framework.Factories
{
    public class BaseTableItemsGenerator : ITableItemsGenerator
    {
        protected readonly Func<ITableItem> _tableItemFactory;
        protected List<ITableItem> _table;

        public BaseTableItemsGenerator(Func<ITableItem> tableItemFactory)
        {
            _tableItemFactory = tableItemFactory;
        }
        public virtual string GoodsKey => nameof(CatalogItem);
        public virtual List<ITableItem> GetItems(CatalogItem catalogItem)
        {
            _table = new List<ITableItem>();
            return _table;
        }

        #region utilites

        protected void AddTitle(string title)
        {
            var item = _tableItemFactory.Invoke();
            item.ItemType = TableItemType.GroupTitle;
            item.Title = title;
            _table.Add(item);
        }
        protected void AddParametr(string title, string parametr)
        {
            var item = _tableItemFactory.Invoke();
            item.ItemType = TableItemType.ItemParametr;
            item.Title = "Freezer camera volume";
            item.Value = parametr;
            _table.Add(item);
        }

        #endregion
    }
}
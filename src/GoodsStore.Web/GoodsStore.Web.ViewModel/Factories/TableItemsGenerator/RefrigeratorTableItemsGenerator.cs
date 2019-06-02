using System;
using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Entities.Goods.HouseholdEquipment;
using GoodsStore.Web.Framework.Interfaces.Factories;
using GoodsStore.Web.Framework.Interfaces.Model;
using GoodsStore.Web.Framework.Keys;

namespace GoodsStore.Web.ViewModel.Factories.TableItemsGenerator
{
    public class RefrigeratorTableItemsGenerator : ITableItemsGenerator
    {
        private readonly Func<ITableItem> _tableItemFactory;

        public RefrigeratorTableItemsGenerator(Func<ITableItem> tableItemFactory)
        {
            _tableItemFactory = tableItemFactory;
        }

        public string GoodsKey => nameof(Refrigerator);
        public List<ITableItem> GetItems(CatalogItem catalogItem)
        {
            var refregerator = catalogItem as Refrigerator;

            var res = new List<ITableItem>();

            var item = _tableItemFactory.Invoke();
            item.ItemType = TableItemType.GroupTitle;
            item.Title = "Volume";
            res.Add(item);

            item = _tableItemFactory.Invoke();
            item.ItemType = TableItemType.ItemParametr;
            item.Title = "Freezer camera volume";
            item.Value = refregerator.FreezerCameraVolume.ToString();
            res.Add(item);

            item = _tableItemFactory.Invoke();
            item.ItemType = TableItemType.ItemParametr;
            item.Title = "Refrigerator camera volume";
            item.Value = refregerator.RefrigeratorCameraVolume.ToString();
            res.Add(item);

            item = _tableItemFactory.Invoke();
            item.ItemType = TableItemType.GroupTitle;
            item.Title = "Size";
            res.Add(item);

            item = _tableItemFactory.Invoke();
            item.ItemType = TableItemType.ItemParametr;
            item.Title = "Height";
            item.Value = refregerator.Height.ToString();
            res.Add(item);

            item = _tableItemFactory.Invoke();
            item.ItemType = TableItemType.ItemParametr;
            item.Title = "Width";
            item.Value = refregerator.Width.ToString();
            res.Add(item);

            return res;
        }
    }
}
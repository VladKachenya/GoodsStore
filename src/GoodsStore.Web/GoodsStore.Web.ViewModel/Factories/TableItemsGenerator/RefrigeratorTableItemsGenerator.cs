using GoodsStore.Core.Domain.Entities.Base;
using GoodsStore.Core.Domain.Entities.Goods.HouseholdEquipment;
using GoodsStore.Web.Framework.Factories;
using GoodsStore.Web.Framework.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace GoodsStore.Web.ViewModel.Factories.TableItemsGenerator
{
    public class RefrigeratorTableItemsGenerator : BaseTableItemsGenerator
    {

        public RefrigeratorTableItemsGenerator(Func<ITableItem> tableItemFactory)
        : base(tableItemFactory)
        {
        }

        public override string GoodsKey => nameof(Refrigerator);
        public override List<ITableItem> GetItems(CatalogItem catalogItem)
        {
            base.GetItems(catalogItem);

            var refregerator = catalogItem as Refrigerator;

            AddTitle("Volume");
            AddParametr("Freezer camera volume", refregerator.FreezerCameraVolume.ToString(CultureInfo.InvariantCulture));
            AddParametr("Refrigerator camera volume", refregerator.RefrigeratorCameraVolume.ToString(CultureInfo.InvariantCulture));

            AddTitle("Size");
            AddParametr("Height", refregerator.Height.ToString(CultureInfo.InvariantCulture));
            AddParametr("Width", refregerator.Width.ToString(CultureInfo.InvariantCulture));

            return _table;
        }
    }
}
using GoodsStore.Core.Domain.Entities.Base;

namespace GoodsStore.Core.Domain.Entities.Goods.HouseholdEquipment
{
    public class Refrigerator : CatalogItem
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double FreezerCameraVolume { get; set; }
        public double RefrigeratorCameraVolume { get; set; }
    }
}
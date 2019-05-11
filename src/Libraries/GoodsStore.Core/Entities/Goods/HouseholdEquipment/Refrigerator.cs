using GoodsStore.Core.Entities;
using GoodsStore.Core.Entities.Base;

namespace GoodsStore.Core.Entities.Goods.HouseholdEquipment
{
    public class Refrigerator : ProductBaseEntity
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double FreezerCameraVolume { get; set; }
        public double RefrigeratorCameraVolume { get; set; }
    }
}
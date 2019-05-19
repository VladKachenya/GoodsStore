namespace GoodsStore.Core.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
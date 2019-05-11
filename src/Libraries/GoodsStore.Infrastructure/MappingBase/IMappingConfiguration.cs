using Microsoft.EntityFrameworkCore;

namespace GoodsStore.Infrastructure.MappingBase
{
    public interface IMappingConfiguration
    {
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}
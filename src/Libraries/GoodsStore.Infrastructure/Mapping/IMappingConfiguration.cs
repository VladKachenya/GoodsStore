using Microsoft.EntityFrameworkCore;

namespace GoodsStore.Infrastructure.Mapping
{
    public interface IMappingConfiguration
    {
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}
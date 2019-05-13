using Microsoft.EntityFrameworkCore;

namespace GoodsStore.Data.Infrastructure.Mapping
{
    public interface IMappingConfiguration
    {
        void ApplyConfiguration(ModelBuilder modelBuilder);
    }
}
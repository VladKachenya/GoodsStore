using System.Threading.Tasks;
using GoodsStore.App.Infrastructure.Helpers;

namespace GoodsStore.Core.Domain.Managers
{
    public interface IManager<TIdentity>
    {
        Task<OperationResult> Create(TIdentity identityEntity, string password);
        Task<OperationResult> Delete(TIdentity identityEntity);
        Task<OperationResult<TIdentity>> FindById(string id);
        Task<OperationResult> Update(TIdentity identityEntity);
    }
}
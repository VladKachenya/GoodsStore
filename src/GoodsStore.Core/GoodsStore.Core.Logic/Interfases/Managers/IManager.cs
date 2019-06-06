using System.Threading.Tasks;
using GoodsStore.App.Infrastructure.Helpers;
using GoodsStore.Core.Identity;

namespace GoodsStore.Core.Logic.Interfases.Managers
{
    public interface IManager<TIdentity>
    {
        Task<OperationResult> Create(TIdentity identityEntity);
        Task<OperationResult> Delete(TIdentity identityEntity);
        Task<OperationResult<TIdentity>> FindById(string id);
        Task<OperationResult> Update(TIdentity identityEntity);
    }
}
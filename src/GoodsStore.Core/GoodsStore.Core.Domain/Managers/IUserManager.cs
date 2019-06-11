using GoodsStore.Core.Domain.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Helpers;

namespace GoodsStore.Core.Domain.Managers
{
    public interface IUserManager 
    {
        Task<OperationResult> Create(IUser identityEntity, string password);
        Task<OperationResult<IUser>> Create(string userName, string email, string password);
        Task<OperationResult> Delete(IUser identityEntity);
        Task<OperationResult<IUser>> FindById(string id);
        Task<OperationResult> Update(IUser identityEntity);
        Task<OperationResult<IUser>> FindByEmail(string email);
        Task<OperationResult<IEnumerable<IUser>>> Users();
        Task<bool> IsInRole(IUser user, string roleName);
    }
}
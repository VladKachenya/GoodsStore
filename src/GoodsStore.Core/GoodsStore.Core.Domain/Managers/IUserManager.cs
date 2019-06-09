using GoodsStore.App.Infrastructure.Helpers;
using GoodsStore.Core.Domain.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodsStore.Core.Domain.Managers
{
    public interface IUserManager : IManager<IUser>
    {
        Task<OperationResult<IUser>> Create(string userName, string email, string password);
        Task<OperationResult<IUser>> FindByEmail(string email);

        Task<OperationResult<IEnumerable<IUser>>> Users();

        Task<bool> IsInRole(IUser user, string roleName);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.App.Infrastructure.Helpers;
using GoodsStore.Core.Domain.Identity;

namespace GoodsStore.Core.Domain.Managers
{
    public interface IUserManager : IManager<IUser>
    {
        Task<OperationResult<IUser>> FindByEmail(string email);

        Task<OperationResult<IEnumerable<IUser>>> Users();

        Task<bool> IsInRole(IUser user, string roleName);
    }
}
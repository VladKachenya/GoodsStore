using System.Collections.Generic;
using System.Threading.Tasks;
using GoodsStore.App.Infrastructure.Helpers;
using GoodsStore.Core.Identity;

namespace GoodsStore.Core.Logic.Interfases.Managers
{
    public interface IUserManager : IManager<GoodsStoreUser>
    {
        Task<OperationResult<GoodsStoreUser>> FindByEmail(string email);

        Task<OperationResult<IEnumerable<GoodsStoreUser>>> Users();

        Task<bool> IsInRole(GoodsStoreUser user, string roleName);
    }
}
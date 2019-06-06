using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStore.App.Infrastructure.Helpers;
using GoodsStore.Core.Identity;
using GoodsStore.Core.Logic.Helpers;
using GoodsStore.Core.Logic.Interfases.Managers;
using Microsoft.AspNetCore.Identity;

namespace GoodsStore.Core.Logic.Managers
{
    public class GoodsStoreUserManager : IUserManager
    {
        private readonly UserManager<GoodsStoreUser> _userManager;
        private readonly IdentityResultToOperatonResultConverters _converter;

        #region ctor

        public GoodsStoreUserManager(UserManager<GoodsStoreUser> userManager, IdentityResultToOperatonResultConverters converter)
        {
            _userManager = userManager;
            _converter = converter;
        }
        #endregion

        #region implementation IUserManager

        public async Task<OperationResult> Create(GoodsStoreUser identityEntity)
        {
            return Convert(await _userManager.CreateAsync(identityEntity));
        }

        public async Task<OperationResult> Delete(GoodsStoreUser identityEntity)
        {
            return Convert(await _userManager.DeleteAsync(identityEntity));
        }

        public async Task<OperationResult<GoodsStoreUser>> FindById(string id)
        {
            return Convert<GoodsStoreUser>(await _userManager.FindByIdAsync(id));

        }

        public async Task<OperationResult> Update(GoodsStoreUser identityEntity)
        {
            return Convert(await _userManager.UpdateAsync(identityEntity));
        }

        public async Task<OperationResult<GoodsStoreUser>> FindByEmail(string email)
        {
            return Convert<GoodsStoreUser>(await _userManager.FindByEmailAsync(email));
        }

        public async Task<OperationResult<IEnumerable<GoodsStoreUser>>> Users()
        {
            return Convert<IEnumerable<GoodsStoreUser>>(_userManager.Users.ToList());
        }

        public async Task<bool> IsInRole(GoodsStoreUser user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
        }
        #endregion

        #region utilities

        private OperationResult Convert(IdentityResult identityResult)
        {
            return _converter.Convert(identityResult);
        }

        private OperationResult<T> Convert<T>(T identityResult)
        {
            return _converter.Convert<T>(identityResult);
        }


        #endregion
    }
}
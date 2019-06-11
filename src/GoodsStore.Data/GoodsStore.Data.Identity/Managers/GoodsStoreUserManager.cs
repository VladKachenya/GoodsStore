using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Helpers;
using GoodsStore.Core.Domain.Identity;
using GoodsStore.Core.Domain.Managers;
using GoodsStore.Data.Identity.Helpers;
using GoodsStore.Data.Identity.IdentityEntities;
using Microsoft.AspNetCore.Identity;

namespace GoodsStore.Data.Identity.Managers
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

        public async Task<OperationResult> Create(IUser identityEntity, string password)
        {
            return Convert(await _userManager.CreateAsync(GetGoodsStoreUser(identityEntity), password));
        }

        public async Task<OperationResult<IUser>> Create(string userName, string email, string password)
        {
            var user = new GoodsStoreUser()
            {
                UserName = userName,
                Email = email
            };
            return _converter.Convert<IUser>(user, await Create(user, password));
        }
        

        public async Task<OperationResult> Delete(IUser identityEntity)
        {
            return Convert(await _userManager.DeleteAsync(GetGoodsStoreUser(identityEntity)));
        }

        public async Task<OperationResult<IUser>> FindById(string id)
        {
            return Convert<IUser>(await _userManager.FindByIdAsync(id));

        }

        public async Task<OperationResult> Update(IUser identityEntity)
        {
            return Convert(await _userManager.UpdateAsync(GetGoodsStoreUser(identityEntity)));
        }

        public async Task<OperationResult<IUser>> FindByEmail(string email)
        {
            return Convert<IUser>(await _userManager.FindByEmailAsync(email));
        }

        public async Task<OperationResult<IEnumerable<IUser>>> Users()
        {
            return Convert<IEnumerable<IUser>>(_userManager.Users.ToList());
        }

        public async Task<bool> IsInRole(IUser user, string roleName)
        {
            
            return await _userManager.IsInRoleAsync(GetGoodsStoreUser(user), roleName);
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

        private GoodsStoreUser GetGoodsStoreUser(IUser user)
        {
            if (user is GoodsStoreUser res)
            {
                return res;
            }
            throw new ArgumentException($"The argument is not a {typeof(GoodsStoreUser).FullName} type");
        }
        #endregion
    }
}
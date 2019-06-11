using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using GoodsStore.Core.Domain.Helpers;
using GoodsStore.Core.Domain.Identity;
using GoodsStore.Core.Domain.Managers;
using GoodsStore.Data.Identity.IdentityEntities;
using Microsoft.AspNetCore.Identity;

namespace GoodsStore.Data.Identity.Managers
{
    public class GoodsStoreSingInManager : ISingInManager
    {
        private readonly SignInManager<GoodsStoreUser> _signInManager;

        #region ctor

        public GoodsStoreSingInManager(SignInManager<GoodsStoreUser> signInManager)
        {
            _signInManager = signInManager;
        }

        #endregion

        #region Implementation of ISingInManager

        public async Task<OperationResult> PasswordSignIn(string userName, string password, bool isPersistent, bool lockoutOnFailure)
        {
            var singInRes = await _signInManager.PasswordSignInAsync(userName, password, isPersistent, lockoutOnFailure);
            if (singInRes.Succeeded) return OperationResult.SucceedResult;
            var errors = new List<string>();
            
            if(singInRes.IsLockedOut) errors.Add($"The user {userName} loked out.");
            if (singInRes.IsNotAllowed) errors.Add($"The user {userName} is not allowed.");
            if (singInRes.RequiresTwoFactor) errors.Add("Requires two factor authentication.");

            return new OperationResult(errors);
        }

        public async Task SignIn(IUser user, bool isPersistent, string authenticationMethod = null)
        {
            if (user == null)
            {
                throw new ArgumentNullException();
            }
            if (!(user is GoodsStoreUser))
            {
                throw new ArgumentException($"The type {user.GetType().Name} is not the {typeof(GoodsStoreUser).FullName} type.");
            }

            var gsUser = user as GoodsStoreUser;

            await _signInManager.SignInAsync(gsUser, isPersistent, authenticationMethod);
        }

        public async Task SignOut()
        {
            await _signInManager.SignOutAsync();
        }

        public bool IsSignedIn(ClaimsPrincipal principal)
        {
            return _signInManager.IsSignedIn(principal);
        }
        #endregion

    }
}
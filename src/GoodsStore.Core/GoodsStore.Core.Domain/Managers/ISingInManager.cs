﻿using System.Security.Claims;
using System.Threading.Tasks;
using GoodsStore.App.Infrastructure.Helpers;
using GoodsStore.Core.Domain.Identity;

namespace GoodsStore.Core.Domain.Managers
{
    public interface ISingInManager
    {
        Task<OperationResult> PasswordSignIn(string userName, string password, bool isPersistent,
            bool lockoutOnFailure);

        Task SignIn(IUser user, bool isPersistent, string authenticationMethod = null);

        Task SignOut();

        bool IsSignedIn(ClaimsPrincipal principal);
    }
}
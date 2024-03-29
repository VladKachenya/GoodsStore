﻿using GoodsStore.App.Infrastructure.App;
using GoodsStore.App.Infrastructure.IoC;
using GoodsStore.Core.Domain.Managers;
using GoodsStore.Data.Identity.Helpers;
using GoodsStore.Data.Identity.Managers;

namespace GoodsStore.Data.Identity.App
{
    public class IdentityDependenciesRegistrar : IDependenciesRegistrar
    {
        public void Register(IContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType(typeof(IdentityResultToOperatonResultConverters));
            containerBuilder.RegisterType<GoodsStoreUserManager, IUserManager>();
            containerBuilder.RegisterType<GoodsStoreSignInManager, ISignInManager>();
        }
    }
}
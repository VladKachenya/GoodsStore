﻿using GoodsStore.App.Infrastructure.App;
using GoodsStore.App.Infrastructure.IoC;
using GoodsStore.Core.Interfaces.Repositories;
using GoodsStore.Data.Infrastructure.Data;

namespace GoodsStore.Data.DataAccess.App
{
    public class DataAccessDependenciesRegistrar : IDependenciesRegistrar
    {
        public void Register(IContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<GoodsStoreDbContext, IDbContext>();
            containerBuilder.RegisterGeneric(typeof(EfRepository<>), typeof(IAsyncRepository<>));
            containerBuilder.RegisterGeneric(typeof(SpecificationEvaluator<>), typeof(ISpecificationEvaluator<>));
        }
    }
}
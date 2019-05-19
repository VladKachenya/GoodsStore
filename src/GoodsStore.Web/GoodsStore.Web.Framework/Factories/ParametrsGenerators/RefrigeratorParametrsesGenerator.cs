﻿using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Infrastructure.Factories;
using GoodsStore.Web.Infrastructure.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoodsStore.Web.Framework.Factories.ParametrsGenerators
{
    public class RefrigeratorParametrsesGenerator : IParametrsGenerator
    {
        public string ProductKey => GoodsKeys.RefrigeratorKey;
        public async Task<List<IParametr>> GetParametrs()
        {
            // Worck here
            return new List<IParametr>();
        }
    }
}
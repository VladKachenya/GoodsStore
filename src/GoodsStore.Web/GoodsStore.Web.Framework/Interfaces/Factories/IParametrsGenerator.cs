﻿using System.Collections.Generic;
using GoodsStore.Core.Domain.Entities;
using GoodsStore.Core.Domain.Keys;
using GoodsStore.Web.Framework.Interfaces.Model;

namespace GoodsStore.Web.Framework.Interfaces.Factories
{
    public interface IParametrsGenerator : IGenerator
    {
        List<IFilterParametr> GetParametrs(ItemType itemType);
    }
}
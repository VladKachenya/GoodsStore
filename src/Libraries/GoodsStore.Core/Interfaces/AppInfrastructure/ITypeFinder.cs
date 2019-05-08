using System;
using System.Collections.Generic;
using System.Reflection;

namespace GoodsStore.Core.Interfaces.AppInfrastructure
{
    public interface ITypeFinder
    {
        IEnumerable<Type> FindClassesOfType<T>();
        IEnumerable<Type> FindClassesOfType(Type assignTypeFrom);
        IList<Assembly> GetAssemblies();
    }
}
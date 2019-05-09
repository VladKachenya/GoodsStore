using System;
using System.Linq;
using GoodsStore.Core.Interfaces.AppInfrastructure;
using GoodsStore.Web.Framework.Interfaces;
using Microsoft.AspNetCore.Routing;

namespace GoodsStore.Web.Framework.Routing
{
    public class RoutePublisher : IRoutePublisher
    {
        private readonly ITypeFinder _typeFinder;

        public RoutePublisher(ITypeFinder typeFinder)
        {
            _typeFinder = typeFinder;
        }

        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {
            var routeProviders = _typeFinder.FindClassesOfType<IRouteProvider>();

            //create and sort instances of route providers
            var instances = routeProviders
                .Select(routeProvider => (IRouteProvider)Activator.CreateInstance(routeProvider))
                .OrderByDescending(routeProvider => routeProvider.Priority);

            //register all provided routes
            foreach (var routeProvider in instances)
                routeProvider.RegisterRoutes(routeBuilder);
        }
    }
}
using System;
using Microsoft.Extensions.DependencyInjection;

namespace MiddlewareEngine
{
    public class HostBuilder
    {
        public void AddMiddleware<TMiddleware>()
        {
            throw new System.NotImplementedException();
        }

        public Host Build()
        {
            throw new System.NotImplementedException();
        }

        public void ConfigureServices(Action<IServiceCollection> configureServices)
        {
            throw new System.NotImplementedException();
        }
    }
}
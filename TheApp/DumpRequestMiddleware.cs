using System;
using System.Threading.Tasks;
using MiddlewareEngine;

namespace TheApp
{
    public class DumpRequestMiddleware
    {
        public async Task InvokeAsync(RequestDelegate next, RequestContext context)
        {
            await Task.Delay(100);
            Console.WriteLine(context.Request);
            await next.Invoke();
        }
    }
}
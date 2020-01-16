using System;
using System.Threading.Tasks;
using MiddlewareEngine;

namespace TheApp
{
    public class DumpRequestMiddleware
    {
        private readonly RequestDelegate _next;

        public DumpRequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(RequestContext context)
        {
            await Task.Delay(100);
            Console.WriteLine(context.Request);
            await _next.Invoke();
        }
    }
}
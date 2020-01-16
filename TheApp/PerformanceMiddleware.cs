using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MiddlewareEngine;

namespace TheApp
{
    public class PerformanceMiddleware
    {
        public async Task InvokeAsync(RequestDelegate next, RequestContext context)
        {
            var stopwatch = Stopwatch.StartNew();
            await next.Invoke();
            stopwatch.Stop();
            Console.WriteLine("Elapsed: " + stopwatch.Elapsed);
        }
    }
}
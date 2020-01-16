using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MiddlewareEngine;

namespace TheApp
{
    public class PerformanceMiddleware
    {
        private readonly RequestDelegate _next;

        public PerformanceMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(RequestContext context)
        {
            var stopwatch = Stopwatch.StartNew();
            await _next.Invoke();
            stopwatch.Stop();
            Console.WriteLine("Elapsed: " + stopwatch.Elapsed);
        }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Middleware
{
    public class Request4Time : IMiddleware
    {
        private readonly ILogger<Request4Time> _logger;
        private readonly Stopwatch _stopWatch;

        public Request4Time(ILogger<Request4Time> logger)
        {
            _logger = logger;
            _stopWatch = new Stopwatch();
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _stopWatch.Start();
            await next.Invoke(context);
            _stopWatch.Stop();

            var s = _stopWatch.ElapsedMilliseconds / 1000;
            if (s > 4)
            {
                var message = $"Request {context.Request.Method} at {context.Request.Path} took {s * 1000} ms";
                _logger.LogInformation(message);
            }
            
            
        }
    }
}

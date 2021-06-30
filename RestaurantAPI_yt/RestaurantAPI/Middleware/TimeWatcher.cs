using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Middleware
{
    public class TimeWatcher : IMiddleware
    {
        private Stopwatch _stopWatch;
        private ILogger<TimeWatcher> _logger;
        public TimeWatcher(ILogger<TimeWatcher> logger)
        {
            _stopWatch = new Stopwatch();
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _stopWatch.Start();
            await next.Invoke(context);
            _stopWatch.Stop();

            var elapSec = _stopWatch.ElapsedMilliseconds;
            if (elapSec / 1000 < 4)
            {
                var message = $"Request [{context.Request.Method}] at {context.Request.Path} took {elapSec} ms";

                _logger.LogInformation(message);
            }
        }
    }
}

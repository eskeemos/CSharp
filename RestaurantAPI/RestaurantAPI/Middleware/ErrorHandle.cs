using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RestaurantAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Middleware
{
    public class ErrorHandle : IMiddleware
    {
        private readonly ILogger<ErrorHandle> _logger;

        public ErrorHandle(ILogger<ErrorHandle> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next.Invoke(context);
            }
            catch(NotFoundException e)
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync(e.Message);
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message,null);

                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("App encounter error");
            }
        }
    }
}

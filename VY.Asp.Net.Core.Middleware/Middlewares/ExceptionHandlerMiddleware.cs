using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace VY.Asp.Net.Core.Middleware.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionHandlerMiddleware> logger;

        public ExceptionHandlerMiddleware(RequestDelegate Next,ILogger<ExceptionHandlerMiddleware> logger)
        {
            next = Next;
            this.logger = logger;
        }


        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await next.Invoke(httpContext);
            }
            catch (Exception ex)
            {
                //Exception Handle Write Debug
                 logger.LogError(ex.Message);
            }
        }
        
    }
}

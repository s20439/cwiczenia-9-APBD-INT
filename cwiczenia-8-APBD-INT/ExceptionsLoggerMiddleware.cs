using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using System;

namespace cwiczenia_8_APBD_INT
{
    public class ExceptionsLoggerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly string path = "logs.txt";

        public ExceptionsLoggerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception exc)
            {
                await LogExceptionAsync(context, exc);
            }
        }

        public async Task LogExceptionAsync(HttpContext context, Exception exc)
        {
            using var stream = new StreamWriter(path, true);
            await stream.WriteLineAsync($"{DateTime.Now},{context.TraceIdentifier},{exc.HResult}");
            await next(context);
        }
    }
}

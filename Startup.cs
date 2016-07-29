using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
namespace AspNetCoreUbuntu
{
    class Startup
    {
        public void Configure(IApplicationBuilder app , ILoggerFactory loggerFactory)
        {
            var logger = loggerFactory.CreateLogger("Configure-Logging");
            logger.LogInformation("Configure Method call {Type}",app.GetType());            
            loggerFactory.AddConsole();

            app.Run(context=> {
                return context.Response.WriteAsync("Hello from AspNetCore");
            });

        }
    }
}
using System;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace ApiNotification.Middleware
{
    public class ConsoleLoggingComponent : OwinMiddleware
    {
        public ConsoleLoggingComponent(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            Console.WriteLine($"Requested: {context.Request.Method} : {context.Request.Path}");
            await Next.Invoke(context);

            Console.WriteLine($"Replied {context.Response.StatusCode}");
        }
    }
}
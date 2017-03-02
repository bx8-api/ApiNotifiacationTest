using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace ApiNotification.Middleware
{
    public class ConsoleLoggingComponent : OwinMiddleware
    {
        public override Task Invoke(IOwinContext context)
        {
            Console.WriteLine(string.Format("Requested: " + context.Request.Method + " : " + context.Request.Path));
            return Next.Invoke(context);
        }

        public ConsoleLoggingComponent(OwinMiddleware next) : base(next)
        {
        }
    }
}

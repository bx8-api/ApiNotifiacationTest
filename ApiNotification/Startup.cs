using ApiNotification;
using ApiNotification.Middleware;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.Hosting;
using Microsoft.Owin.StaticFiles;
using Owin;
using System;
using System.Threading;
using System.Web.Http;

[assembly: OwinStartup(typeof(Startup))]

namespace ApiNotification
{
    internal class Startup
    {
        private static readonly ManualResetEvent ExitEvent = new ManualResetEvent(false);

        public static void Main()
        {
            var uri = "http://*:803";
            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Started!");
                ExitEvent.WaitOne();
            }
        }

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.RegisterRoutes();

            app.Use<ConsoleLoggingComponent>()
                .UseWebApi(config);

            app.UseFileServer(new FileServerOptions()
            {
                DefaultFilesOptions =
                {
                    FileSystem = new PhysicalFileSystem("./www")
                }
            });
        }
    }
}
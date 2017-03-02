using System.Web.Http;

namespace ApiNotification
{
    public static class HttpConfigurationExtensions
    {
        public static HttpConfiguration RegisterRoutes(this HttpConfiguration httpConfig)
        {
            WebApiConfig.Register(httpConfig);
            return httpConfig;
        }
    }
}

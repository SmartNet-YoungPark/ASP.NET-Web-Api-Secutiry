using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Cors;

namespace Web_API_Service_with_Basic_Authentication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            System.Web.Http.Cors.EnableCorsAttribute cors = 
                        new System.Web.Http.Cors.EnableCorsAttribute("*", "*", "*");

            config.EnableCors();
        }
    }
}

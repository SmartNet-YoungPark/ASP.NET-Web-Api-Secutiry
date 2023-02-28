using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Basic_Authentication_Using_Message_Handler_in_Web_API.Models;


namespace Basic_Authentication_Using_Message_Handler_in_Web_API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {   //---------------Test customized Server message handler ---------------
            // Web API configuration and services
            config.MessageHandlers.Add(new BasicAuthenticationMessageHandler());
            //----------------Test Server message handler---------------------------
            // config.MessageHandlers.Add(new MessageHandler1());

            //This handler will be the first called because of skipping 
            //The other message is not available until this message process.
            // 
            //config.MessageHandlers.Add(new MessageHandler2());

            //---------------------------------------------------------------------
            //config.MessageHandlers.Add(new CustomHeaderHandler());
            //---------------------------------------------------------------------

            //config.MessageHandlers.Add(new XHTTPMethodOverrideHandler());

            //---------------------------------------------------------------------
            config.MessageHandlers.Add(new ApiKeyHandler());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }

            );
            
        }
    }
}

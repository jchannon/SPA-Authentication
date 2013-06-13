﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApi_BasicAuth_MessageHandler
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            GlobalConfiguration.Configuration.MessageHandlers.Add(new BasicAuthenticationHandler());
        }
    }
}
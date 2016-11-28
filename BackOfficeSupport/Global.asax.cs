﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcApplication1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            

			-------AuthConfig.RegisterAuth();
			-------BundleConfig.RegisterBundles(BundleTable.Bundles);
			-------RouteConfig.RegisterRoutes(RouteTable.Routes);
			-------FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            -------WebApiConfig.Register(GlobalConfiguration.Configuration);
			
			-------AreaRegistration.RegisterAllAreas();
        }
    }
}
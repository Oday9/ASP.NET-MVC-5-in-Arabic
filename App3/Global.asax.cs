using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace App3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            HtmlHelper.ClientValidationEnabled = false;
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}

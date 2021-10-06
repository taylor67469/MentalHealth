using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
namespace MentalHealth
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RouteTable.Routes.MapHttpRoute(
    name: "MentalHealthApi",
    routeTemplate: "api/{controller}/{id}",
    defaults: new { id =RouteParameter.Optional }
);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
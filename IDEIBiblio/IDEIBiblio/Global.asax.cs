using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using IDEIBiblio.DAL;
using System.Data.Entity.Infrastructure.Interception;

namespace IDEIBiblio
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //System.Data.Entity.Database.SetInitializer(new IDEIBiblio.Models.SampleData());

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbInterception.Add(new IDEIBiblioInterceptorTransientError());
            DbInterception.Add(new IDEIBiblioLogging());
            AuthConfig.RegisterAuth();
        }
    }
}
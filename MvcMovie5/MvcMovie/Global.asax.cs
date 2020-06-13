using MvcMovie.Models; // MovieInitializer
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcMovie
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //added by eddddyyyyyyyyyyyyyyyyyyyyyyyy
            Database.SetInitializer<MovieDBContext>(new MovieInitializer());

            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default eddddddyyyyyyyyyy
            Database.DefaultConnectionFactory = new SqlConnectionFactory("Data Source = (localdb)\v11.0; Integrated Security = True; MultipleActiveResultSets = True");

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

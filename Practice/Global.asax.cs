using Practice.Models.DAL;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;

namespace Practice
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MovieContext>());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}

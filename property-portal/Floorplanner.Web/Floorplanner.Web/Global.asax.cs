using System.Web.Mvc;
using System.Web.Routing;

namespace Floorplanner.Web
{

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "EditUser",
                "user/edit/{id}",
                new { controller = "User", action = "Edit" },
                new { id = @"\d+" }
            );

            routes.MapRoute(
                "DeleteUser",
                "user/delete/{id}",
                new { controller = "User", action = "Delete" },
                new { id = @"\d+" }
            );

            routes.MapRoute(
                "DeleteProject",
                "user/{userId}/project/delete/{id}",
                new { controller = "Project", action = "Delete" },
                new { id = @"\d+", userId = @"\d+" }
            );

            routes.MapRoute(
                "EditProject",
                "user/{userId}/project/edit/{id}",
                new { controller = "Project", action = "Edit" },
                new { id = @"\d+", userId = @"\d+" }
            );

            routes.MapRoute(
                "ShowProject",
                "user/{userId}/project/{id}/2D",
                new { controller = "Project", action = "Details" },
                new { id = @"\d+", userId = @"\d+" }
            );

            routes.MapRoute(
                "CreateUser",
                "user/add",
                new { controller = "User", action = "Add" }
            );

            routes.MapRoute(
                "Root",
                "",
                new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                "Home",
                "home",
                new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
                "LoggedInAsAdministrator",
                "loggedinasadministrator",
                new { controller = "Home", action = "LoggedInAsAdministrator" }
            );

            routes.MapRoute(
                "LoggedInAsPro",
                "loggedinaspro/user/{id}",
                new { controller = "Project", action = "Index" },
                new { id = @"\d+" }
            );

            routes.MapRoute(
                "AddProject",
                "loggedinaspro/user/{userId}/newproject",
                new { controller = "Project", action = "Add" },
                new { userId = @"\d+" }
            );

            routes.MapRoute(
                "LogInAsPro",
                "loginaspro",
                new { controller = "Home", action = "LoginAsPro" }
            );

        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }
    }
}
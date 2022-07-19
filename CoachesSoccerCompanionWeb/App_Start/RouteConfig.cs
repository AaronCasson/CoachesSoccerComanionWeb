using System.Web.Mvc;

namespace CoachesSoccerCompanionWeb.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Button",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Button", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Test",
                url: "{test}",
                defaults: new { controller = "Test", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

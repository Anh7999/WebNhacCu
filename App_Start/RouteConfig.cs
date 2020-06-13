using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace web12
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("News", "{type}",
            new { controller = "News", action = "Index" },
            new RouteValueDictionary
            {
                { "type", "tin-tuc" }
            },
            namespaces: new[] { "web12.Controllers" });
            routes.MapRoute("Product", "{type}/{meta}",
            new { controller = "Product", action = "Index", meta = UrlParameter.Optional },
            new RouteValueDictionary
            {
                { "type", "san-pham" }
            },
             namespaces: new[] { "web12.Controllers" });
            routes.MapRoute("Home", "{type}/{meta}",
            new { controller = "Home", action = "Index", meta = UrlParameter.Optional },
            new RouteValueDictionary
            {
                { "type", "trang-chu" }
            },
            namespaces: new[] { "web12.Controllers" });
            routes.MapRoute("Detail", "{type}/{meta}/{id}",
            new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
            new RouteValueDictionary
            {
                { "type", "san-pham" }
            },
            namespaces: new[] { "web12.Controllers" });

            // routes.MapRoute("getContact", "{type}/{meta}",
            //new { controller = "Contact", action = "getContact", meta = UrlParameter.Optional },
            //new RouteValueDictionary
            //{
            //     { "type", "lien-he" }
            //},


            //namespaces: new[] { "web12.Controllers" });

            //routes.MapRoute("Contact", "{type}",
            //new { controller = "Contact", action = "getContact" },
            //new RouteValueDictionary
            //{
            //    { "type", "lien-he" }
            //},
            //namespaces: new[] { "web12.Controllers" });
            routes.MapRoute("Contact", "{type}/{meta}",
          new { controller = "Contact", action = "getContact", meta = UrlParameter.Optional },
          new RouteValueDictionary
          {
                { "type", "lien-he" }
          },
          namespaces: new[] { "web12.Controllers" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "web12.Controllers" }
            );

        namespaces: new[] { "web12.Controllers" });
            routes.MapRoute("Detail", "{type}/{meta}/{id}",
            new { controller = "User", action = "Register", id = UrlParameter.Optional },
            new RouteValueDictionary
            {
                { "Dang-Ky", "Register" }
            },
            namespaces: new[] { "web12.Controllers" });
        }
    }
}
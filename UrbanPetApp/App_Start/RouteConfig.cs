using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrbanPetApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
             name: "Checkout",
             url: "ShoppingCart/Checkout",
             defaults: new { controller = "ShoppingCarts", action = "Checkout" }
);
            routes.MapRoute(
             name: "AddToCart",
             url: "ShoppingCart/AddToCart",
             defaults: new { controller = "ShoppingCart", action = "AddToCart" }
            );

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}

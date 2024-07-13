using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Moneyshowertech.PL
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Index/TR",
                url: "{language}/Anasayfa",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, language = "TR" }
            );
            routes.MapRoute(
                name: "Index/DE",
                url: "{language}/Startseite",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, language = "TR" }
            );
            routes.MapRoute(
                name: "Index/En",
                url: "{language}/Home",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, language = "TR" }
            );



            routes.MapRoute(
              name: "BillingInfo/TR",
              url: "{language}/Faturalandirma",
              defaults: new { controller = "Home", action = "BillingInfo", id = UrlParameter.Optional, language = "TR" }
          );
            routes.MapRoute(
           name: "BillingInfo/EN",
           url: "{language}/Billing",
           defaults: new { controller = "Home", action = "BillingInfo", id = UrlParameter.Optional, language = "TR" }
       );
            routes.MapRoute(
        name: "BillingInfo/DE",
        url: "{language}/Abrechnung",
        defaults: new { controller = "Home", action = "BillingInfo", id = UrlParameter.Optional, language = "TR" }
 );



            routes.MapRoute(
              name: "SSS/TR",
              url: "{language}/SSS",
              defaults: new { controller = "Home", action = "SSS", id = UrlParameter.Optional, language = "TR" }
          );
            routes.MapRoute(
            name: "FAQ/EN",
            url: "{language}/FAQ",
            defaults: new { controller = "Home", action = "SSS", id = UrlParameter.Optional, language = "TR" }
            );
            routes.MapRoute(
            name: "HGF/DE",
             url: "{language}/HGF",
            defaults: new { controller = "Home", action = "SSS", id = UrlParameter.Optional, language = "TR" }
            );



            routes.MapRoute(
              name: "Hakkımızda/TR",
              url: "{language}/Hakkımızda",
              defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional, language = "TR" }
          );
            routes.MapRoute(
          name: "About/EN",
          url: "{language}/About",
          defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional, language = "TR" }
      );
            routes.MapRoute(
             name: "Uberuns/DE",
            url: "{language}/Uberuns",
            defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional, language = "TR" }
                   );

            routes.MapRoute(
             name: "ThingShower",
         url: "{language}/ThingShower",
         defaults: new { controller = "Home", action = "ThingShower", id = UrlParameter.Optional, language = "TR" }
                );
            routes.MapRoute(
             name: "MoneyShower",
         url: "{language}/MoneyShower",
         defaults: new { controller = "Home", action = "MoneyShower", id = UrlParameter.Optional, language = "TR" }
                );
             routes.MapRoute(
             name: "MoneyCountingShower",
         url: "{language}/MoneyCountingShower",
         defaults: new { controller = "Home", action = "MoneyCountingShower", id = UrlParameter.Optional, language = "TR" }
                );
            routes.MapRoute(
             name: "Galeri",
         url: "{language}/Galeri",
         defaults: new { controller = "Home", action = "Gallery", id = UrlParameter.Optional, language = "TR" }
                );
            routes.MapRoute(
        name: "Sepet",
    url: "{language}/Sepet",
    defaults: new { controller = "Home", action = "Sepet", id = UrlParameter.Optional, language = "TR" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{language}/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, language = "TR" }
            );
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Routing;

//namespace AcunMedyaAkademiPortfolio
//{
//    public class RouteConfig
//    {
//        public static void RegisterRoutes(RouteCollection routes)
//        {
//            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

//            routes.MapRoute(
//                name: "Default",
//                url: "{controller}/{action}/{x}",
//                defaults: new { controller = "Testimonial", action = "Index", id = UrlParameter.Optional }
//            );
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AcunMedyaAkademiPortfolio
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Varsayılan rotayı düzeltelim -*-- yüksek ihtimalle yaptığın bir değişiklik buraya da yansıdı, bu kodu chate attığımda x yerine id koydu bu kısımda neden x koydu yalan yok benim de fikrim yok :) 
            // şu anda sorunsuz çalışıyor gözüküyor şurayı bir araştırmak lazım .Evet teşekkür ederim rica ederim iyi akşamlar.iyi akşamlar
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}", // {x} yerine {id} kullanıyoruz
                defaults: new { controller = "Testimonial", action = "Index", id = UrlParameter.Optional } // id burada opsiyonel
            );
        }
    }
}

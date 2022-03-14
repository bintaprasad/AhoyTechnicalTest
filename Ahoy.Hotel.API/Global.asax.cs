using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using System.Data.Entity;
using Ahoy.Hotel.Data.AhoyHotelDataContext;

namespace Ahoy.Hotel.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            UnityConfig.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            Database.SetInitializer(new AhoyHotelDatabaseInitializer());

            AhoyHotelDatabaseContext context = new AhoyHotelDatabaseContext();
            context.Database.Initialize(true);
            context.Database.CreateIfNotExists();
        }
    }
}

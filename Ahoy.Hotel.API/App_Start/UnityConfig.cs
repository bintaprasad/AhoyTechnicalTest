using System.Web.Http;
using Unity;
using Unity.WebApi;
using Ahoy.Hotel.Data;
using Ahoy.Hotel.Data.IData;
using Ahoy.Hotel.Business;
using Ahoy.Hotel.Business.IBusiness;
using Unity.Lifetime;

namespace Ahoy.Hotel.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IHotelRepository, HotelRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IBookingRepository,BookingRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IHotelManager, HotelManager>(new HierarchicalLifetimeManager());
            container.RegisterType<IBookingManager, BookingManager>(new HierarchicalLifetimeManager());

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
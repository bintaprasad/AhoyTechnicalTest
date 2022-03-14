using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Ahoy.Hotel.Entities;
using Ahoy.Hotel.Entities.Models;

namespace Ahoy.Hotel.Data.AhoyHotelDataContext
{
    public class AhoyHotelDatabaseContext:DbContext
    {
        public AhoyHotelDatabaseContext():base("AhoyHotelAppDBEntities")
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Ahoy.Hotel.Entities.Models.Hotel> Hotels { get; set; }

        //public DbSet<HotelStay> HotelStays { get; set; }
        public DbSet<HotelFacility> HotelFacilities { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Ahoy.Hotel.Entities.Models;

namespace Ahoy.Hotel.Data.AhoyHotelDataContext
{
    public class AhoyHotelDatabaseInitializer:DropCreateDatabaseAlways<AhoyHotelDatabaseContext>
    {
        protected override void Seed(AhoyHotelDatabaseContext context)
        {
            base.Seed(context);

            // Inserting data to respective tables

            context.Countries.AddOrUpdate(new Country[]{
                 new Country() { CountryId = 1, CountryName = "Indonesia",ShortCode="IDN" },
                 new Country() { CountryId = 2, CountryName = "Malaysia",ShortCode="MYS" },
                 new Country() { CountryId = 3, CountryName = "Italy",ShortCode="ITA" },
                 
            });

            context.States.AddOrUpdate(new State[]{
                 new State() { StateId = 1, StateName = "East Java",CountryId=1 },
                 new State() { StateId = 2, StateName = "Papua",CountryId=1 }
               

            });

            context.Cities.AddOrUpdate(new City[]{
                 new City() { CityId = 1, CityName = "Malang",StateId=1 },
                 new City() { CityId = 2, CityName = "Jayapura",StateId = 2 }
                 

            });

            context.Facilities.AddOrUpdate(new Facility[]{
                 new Facility() { FacilityId = 1, FacilityCode = "BKFST",FacilityName="Breakfast"},
                 new Facility() { FacilityId = 2, FacilityCode = "WIFI",FacilityName="Wifi"},
                 new Facility() { FacilityId = 3, FacilityCode = "PRKG",FacilityName="Parking"},
                 new Facility() { FacilityId = 4, FacilityCode = "SPA",FacilityName="Spa"}


            });

            context.Hotels.AddOrUpdate(new Entities.Models.Hotel[]{
                 new Entities.Models.Hotel() { HotelId = 1,
                     HotelName = "Sahid Montana",
                     HotelDescription ="Hotel Sahid Montana Malang is a 4 star complemented hotel",
                     StreetAddress1="JL Kahuripan No 9, RW3,Kauman",
                     StreetAddress2="Kec,Klojan",
                     CityId=1,
                     StateId=1,
                     CountryId=1,
                     Latitude=-7.97494864865,
                     Longitude=112.632841351,
                     Rating=4

                 },
                 new Entities.Models.Hotel() { HotelId = 2,
                     HotelName = "Grand Canyon",
                     HotelDescription ="Hotel Grand Canyon is a 4 star complemented hotel",
                     StreetAddress1="Sodirman Street",
                     StreetAddress2="",
                     CityId=2,
                     StateId=2,
                     CountryId=1,
                     Latitude=-7.9749345865,
                     Longitude=112.543841351,
                     Rating=3

                 },


            });

            context.HotelFacilities.AddOrUpdate(new HotelFacility[]{

                 new HotelFacility() { HotelFacilityId = 1, HotelId =1,FacilityId=1},
                 new HotelFacility() { HotelFacilityId = 2, HotelId =1,FacilityId=2},
                 new HotelFacility() { HotelFacilityId = 3, HotelId =1,FacilityId=3},
                 new HotelFacility() { HotelFacilityId = 4, HotelId =1,FacilityId=4},
                 new HotelFacility() { HotelFacilityId = 5, HotelId =2,FacilityId=2},
                 new HotelFacility() { HotelFacilityId = 6, HotelId =2,FacilityId=3}


            });


            context.SaveChanges();

        }
    }
}
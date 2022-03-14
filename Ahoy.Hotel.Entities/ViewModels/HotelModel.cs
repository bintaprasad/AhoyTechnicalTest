using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ahoy.Hotel.Entities.ViewModels
{
    public class HotelModel
    {
        public long HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelDescription { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public long CityId { get; set; }
        public string CityName { get; set; }
        public long StateId { get; set; }
        public string StateName { get; set; }
        public long CountryId { get; set; }
        public string CountryName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Rating { get; set; }
        public string Address { get; set; }
        public decimal TotalFare { get; set; }

        public List<FacilityModel> Facilities { get; set; }
    }
}
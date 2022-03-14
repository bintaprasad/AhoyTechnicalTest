using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ahoy.Hotel.Models
{
    public class Hotel
    {
        [Key]
        public long HotelId { get; set; }
        public string HotelName { get; set; }
        public string Description { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public int Rating { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public Country Country { get; set; }
    }
}

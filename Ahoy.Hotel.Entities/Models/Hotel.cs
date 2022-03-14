using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ahoy.Hotel.Entities.Models
{
    public class Hotel
    {
        [Key]
        public long HotelId { get; set; }
        [Required]
        public string HotelName { get; set; }
        public string HotelDescription { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }      
        public long StateId { get; set; }      
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Rating { get; set; }
        public decimal TotalFare { get; set; }
        public long CountryId { get; set; }
        public Country Country { get; set; }
        public long CityId { get; set; }
        public City City { get; set; }
        public State State { get; set; }
    }
}
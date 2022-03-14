using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ahoy.Hotel.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string ShortName { get; set; }

        public List<Hotel> TouristHotels { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ahoy.Hotel.Entities.Models
{
    public class HotelFacility
    {
        [Key]
        public long HotelFacilityId { get; set; }
        public int FacilityId { get; set; }
        public long HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public Facility Facility { get; set; }
    }
}
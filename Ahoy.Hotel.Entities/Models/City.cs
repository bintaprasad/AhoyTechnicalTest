using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ahoy.Hotel.Entities.Models
{
    public class City
    {
        [Key]
        public long CityId { get; set; }
        [Required]
        public string CityName { get; set; }
        public long StateId { get; set; }
        public State State { get; set; }
    }
}
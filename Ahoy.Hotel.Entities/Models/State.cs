using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ahoy.Hotel.Entities.Models
{
    public class State
    {
        [Key]
        public long StateId { get; set; }
        [Required]
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Ahoy.Hotel.Entities.Models
{
    public class Facility
    {
        [Key]
        public int FacilityId { get; set; }
        [Required]
        public string FacilityName { get; set; }
        public string FacilityCode { get; set; }
    }
}
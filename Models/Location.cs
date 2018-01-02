using System;
using System.ComponentModel.DataAnnotations;

namespace dn_mvc_loc
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string HouseNum { get; set; }
        public string City{ get; set; }
        public string Street { get; set; }
        public string Region { get; set; }
        public string Code { get; set; }
    }
}

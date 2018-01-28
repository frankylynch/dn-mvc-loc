using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dn_mvc_loc
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public string Location { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace dn_mvc_loc
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string City { get; set; }
    }
}

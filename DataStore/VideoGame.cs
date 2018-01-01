
using System.ComponentModel.DataAnnotations;

namespace dn_mvc_loc
{
    public class VideoGame
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Platform { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_TicketsApplication.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]

        public string Fullname { get; set; }
        [Display(Name = "Biography")]

        public string Bio { get; set; }
        //Relationships
        public List<Movie> Movies { get; set; }
    }
}

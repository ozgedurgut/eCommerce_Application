using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_TicketsApplication.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Pic is required")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50,MinimumLength =3, ErrorMessage = "Full name must be between 3 and 50 chars")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Biography is required")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public string ShortBio
        {
            get
            {
                if (Bio.Length <= 7)
                {
                    return Bio;
                }
                return Bio.Substring(0, 7) + "...";
            }
        }

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
    }


}

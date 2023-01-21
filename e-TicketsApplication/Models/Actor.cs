﻿using System;
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
        public string ProfilePictureURL { get; set; }

        public string Fullname { get; set; }
        public string FullName { get; internal set; }
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
    }


}

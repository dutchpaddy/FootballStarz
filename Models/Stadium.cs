﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStarz.Models
{
    public class Stadium
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter stadium name.")]
        [DataType(DataType.Text)]
        [Display(Name = "Stadium Name")]
        public string StadiumName { get; set; }
        
        public DateTime BuildDate { get; set; }
        [Required]
        
        // Relations
        public virtual Club Club { get; set; }
        [Display(Name = "Club Name")]
        public int ClubId { get; set; }

    }
}



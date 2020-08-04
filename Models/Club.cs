﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FootballStarz.Validator;

namespace FootballStarz.Models
{
    public class Club
    {
        [Key]
        public int ClubId { get; set; }

        [Required(ErrorMessage = "Club name required.")]
        [Display(Name = "Club name")]
        [DataType(DataType.Text)]
        public string ClubName { get; set; }

        [Required(ErrorMessage = "Founded required.")]
        [Display(Name = "Founded")]
        [DataType(DataType.Date)]
        public DateTime Founded { get; set; }

        [Display(Name = "Club Logo")]
        [DataType(DataType.Text)]
        [ClubLogoValidation]
        public string ClubLogo { get; set; }

        [Required(ErrorMessage = "Stadium name required.")]
        [Display(Name = "Stadium Name")]
        public int StadiumId { get; set; }

    }
}

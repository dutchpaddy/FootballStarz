using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStarz.Models
{
    public class Club
    {
        [Key]
        public int ClubId { get; set; }

        [Required(ErrorMessage = "Club name required.")]
        [Display(Name = "Club name")]
        public string ClubName { get; set; }

        [Required(ErrorMessage = "Founded required.")]
        [Display(Name = "Founded")]
        public DateTime Founded { get; set; }

        [Display(Name = "Club Logo")]
        public string ClubLogo { get; set; }

[Required(ErrorMessage = "Stadium name required.")]
        [Display(Name = "Stadium Name")]
        public int StadiumId { get; set; }

    }
}

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

        [Display(Name = "Club name")]
        public string ClubName { get; set; }

        [Display(Name = "Founded")]

        public DateTime Founded { get; set; }

    }
}

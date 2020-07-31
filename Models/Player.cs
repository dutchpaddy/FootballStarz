using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStarz.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Display(Name = "Player name")]
        public string PlayerName { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        // Relations
        public int ClubId { get; set; }

    }
}

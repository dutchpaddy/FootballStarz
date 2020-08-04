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

        [Required(ErrorMessage = "Player name required.")]
        [Display(Name = "Player name")]
        public string PlayerName { get; set; }

        [Required(ErrorMessage = "Birthdate required.")]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Nationality required.")]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }
        
        [Display(Name = "Player Image")]
        public string PlayerImage { get; set; }

        // Relations
        [Required(ErrorMessage = "Club required..")]
        public int ClubId { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace FootballStarz.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required(ErrorMessage = "Player name required.")]
        [Display(Name = "Player name")]
        [DataType(DataType.Text)]

        public string? PlayerName { get; set; }

        [Required(ErrorMessage = "Birthdate required.")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]

        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Nationality required.")]
        [Display(Name = "Nationality")]
        [DataType(DataType.Text)]

        public string? Nationality { get; set; }

        [Required(ErrorMessage = "Player image required.")]
        [Display(Name = "Player Image")]
        [DataType(DataType.Text)]
        //[PlayerImageValidation]

        public string? PlayerImage { get; set; }

        // Relations
        [Required(ErrorMessage = "Club required..")]
        public int ClubId { get; set; }

    }
}

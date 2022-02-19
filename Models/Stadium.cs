using System;
using System.ComponentModel.DataAnnotations;

namespace FootballStarz.Models
{
    public class Stadium
    {
        [Key]
        public int StadiumId { get; set; }

        [Required(ErrorMessage = "Stadium name required.")]
        [Display(Name = "Stadium Name")]
        [DataType(DataType.Text)]

        public string StadiumName { get; set; }

        [Required(ErrorMessage = "Date built required.")]
        [Display(Name = "Date Built")]
        [DataType(DataType.Date)]
        public DateTime BuildDate { get; set; }

        [Required(ErrorMessage = "Location required.")]
        [Display(Name = "Location")]
        [DataType(DataType.Text)]

        public string Location { get; set; }

        [Required(ErrorMessage = "Stadium Image required.")]
        [DataType(DataType.Text)]
        [Display(Name = "Stadium Image")]

        public string StadiumImage { get; set; }

        [Required(ErrorMessage = "Club required.")] 
        public int ClubId { get; set; }

    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStarz.Models
{
    public class Stadium
    {
        [Key]
        public int StadiumId { get; set; }

        [Required(ErrorMessage = "Please enter stadium name.")]
        [DataType(DataType.Text)]
        [Display(Name = "Stadium Name")]
        public string StadiumName { get; set; }

        [Display(Name = "Date Built")]
        public DateTime BuildDate { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        public int ClubId { get; set; }

    }
}



using System;
using System.ComponentModel.DataAnnotations;

namespace FootballStarz.Models
{
    public class Liga
    {
        [Key]
        public int LigaId { get; set; }

        [Required(ErrorMessage = "Liga name required.")]
        [Display(Name = "Liga name")]
        [DataType(DataType.Text)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Season YYYY-YYYY required.")]
        [Display(Name = "Season")]
        [DataType(DataType.Text)]
        public string? Season { get; set; }

        [Required(ErrorMessage = "ISO Country code required.")]
        [Display(Name = "ISO Country code")]
        [DataType(DataType.Text)]
        public string? IsoCountryCode { get; set; }

    }
}

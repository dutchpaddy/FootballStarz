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

        public string ClubName { get; set; }

        public DateTime Founded { get; set; }

    }
}

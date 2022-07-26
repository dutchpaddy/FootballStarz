using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Models;

namespace FootballStarz.ViewModels
{
    public class ClubViewModel
    {
        public int ClubId { get; set; }

        public string? ClubName { get; set; }

        public DateTime Founded { get; set; }

        public string? ClubLogo { get; set; }

        public int? StadiumId { get; set; }
        public Stadium? Stadium { get; set; }

        public int Version { get; set; }
        public DateTime? LastUpdated { get; set; }
        
        public string? LigaName { get; set; }
        public string? Season { get; set; }
        public string? Country { get; set; }
        public List<Player>? Players { get; set; }
    
    }
}

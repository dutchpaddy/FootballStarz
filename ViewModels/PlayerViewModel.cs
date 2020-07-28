using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStarz.ViewModels
{
    public class PlayerViewModel
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public DateTime BirthDate{ get; set; }
        public String Nationality { get; set; }
    }
}

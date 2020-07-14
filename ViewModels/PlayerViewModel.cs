using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStarz.ViewModels
{
    public class PlayerViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public object PlayerName { get; internal set; }
    }
}

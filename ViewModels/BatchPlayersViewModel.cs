﻿using FootballStarz.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballStarz.ViewModels
{
    public class BatchPlayersViewModel
    {
        [BindProperty]
        public List<Player> BatchPlayers { get; set; }
    }
}

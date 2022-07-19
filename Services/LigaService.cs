using System;
using System.Collections.Generic;
using System.Linq;
using FootballStarz.Data;
using FootballStarz.Models;
using FootballStarz.ViewModels;
using FootballStarz.Interfaces;
using Microsoft.Extensions.Logging;

namespace FootballStarz.Services
{
    public class LigaService : ILigaService
    {
        private readonly AppDbContext _context;
        //private readonly ILogger _logger;

        public LigaService(/*ILogger<ClubService> logger, */ AppDbContext context)
        {
        //    _logger = logger;
            _context = context;
        }


        public Liga GetSingleLigaById(int ligaId) => _context.Ligas.Where(n => n.LigaId == ligaId).FirstOrDefault();

    }
}




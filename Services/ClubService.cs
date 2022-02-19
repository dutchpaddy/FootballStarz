using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Data;
using FootballStarz.Models;
using FootballStarz.ViewModels;
using FootballStarz.Interfaces;
using Microsoft.Extensions.Logging;

namespace FootballStarz.Services
{
    public class ClubService : IClubService
    {
        private AppDbContext _context;
        private readonly ILogger _logger; 

        public ClubService(ILogger<ClubService> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;

        }


        public List<Club> GetAllClubs()
        {
            return _context.Clubs.ToList();
        }

        public List<Stadium>GetAllStadiums()
        {
            return _context.Stadiums.ToList();
        }

        public List<Player> GetAllPlayers()
        {
            return _context.Players.ToList();
        }

        public List<String> GetAllClubLogos()
        {
             List<String> Logos = (from c in _context.Clubs
                                  select c.ClubLogo).ToList<String>();

            return Logos;
        }
    
        public void AddClub(Club club)
        {
            _logger.LogInformation($"AddClub- club: {club}");

            _context.Clubs.Add(club);
            _context.SaveChanges();
        }

        public Club GetSingleClubById(int id) => _context.Clubs.Where(n => n.ClubId == id).FirstOrDefault();

        public void UpdateClub(Club newClub)
        {
            _logger.LogInformation($"UpdateClub- newClub: {newClub.ClubName}");

            Club oldClub = GetSingleClubById(newClub.ClubId);

            oldClub.ClubId = newClub.ClubId;
            oldClub.ClubName = newClub.ClubName;
            oldClub.Founded = newClub.Founded;
            oldClub.ClubLogo = newClub.ClubLogo;		// Read image from storage; see WorldJourney example
            oldClub.StadiumId = newClub.StadiumId;

            _context.SaveChanges();
        }

        public void DeleteClub(int id)
        {
            _logger.LogInformation($"DeleteClub- id: {id}");

            Club clubToBeDeleted = GetSingleClubById(id);
            _context.Clubs.Remove(clubToBeDeleted);
            _context.SaveChanges();
        }

        public List<Player> GetPlayersByClubId(int clubId) => _context.Players.Where(n => n.ClubId == clubId).ToList();

        public Stadium GetStadiumByStadiumId(int StadiumId) => _context.Stadiums.Where(n => n.StadiumId == StadiumId).FirstOrDefault();


        public ClubViewModel ClubDeletionConfirmation(int id)
        {
            _logger.LogInformation($"ClubDeletionConfirmation- id: {id}");

            Club Club = GetSingleClubById(id);
            Stadium Stadium = GetStadiumByStadiumId(Club.StadiumId);
            List<Player> Players = GetPlayersByClubId(Club.ClubId);

            ClubViewModel ClubVM = new ClubViewModel()
            {
                ClubId = Club.ClubId,
                ClubName = Club.ClubName,
                Founded = Club.Founded,
                ClubLogo = Club.ClubLogo,
                Stadium = Stadium,
                Players = Players
            };

            return ClubVM;

        }

        //public ClubViewModel ClubDetails(int id)
        //{
        //    _logger.LogInformation($"ClubDetails- id: {id}");

        //    Club club = GetSingleClubById(id);
        //    Stadium stadium = GetStadiumByStadiumId(club.StadiumId);
        //    List<Player> players = GetPlayersByClubId(club.ClubId);

        //    ClubViewModel clubVM = new ClubViewModel()
        //    {
        //        ClubId = club.ClubId,
        //        ClubName = club.ClubName,
        //        Founded = club.Founded,
        //        ClubLogo = club.ClubLogo,
        //        Stadium = stadium,
        //        Players = players
        //    };

        //    return clubVM;

        //}
    }
}

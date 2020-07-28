using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Data;
using FootballStarz.Models;
using FootballStarz.ViewModels;

namespace FootballStarz.Services
{
    public class ClubService : IClubService
    {
        private AppDbContext _context;
        public ClubService(AppDbContext context)
        {
            _context = context;
        }
        public void AddClub(Club club)
        {
            _context.Clubs.Add(club);
            _context.SaveChanges();
        }

        public void DeleteClub(int id)
        {
            Club clubToBeDeleted = GetSingleClubById(id);
            _context.Clubs.Remove(clubToBeDeleted);
            _context.SaveChanges();
        }

        public List<Club> GetAllClubs()
        {
            return _context.Clubs.ToList();
        }

        public Club GetSingleClubById(int id) => _context.Clubs.Where(n => n.ClubId == id).FirstOrDefault();

        public List<Stadium> GetStadiumByClubId(int clubId) => _context.Stadiums.Where(n => n.ClubId == clubId).ToList();

        public List<Player> GetPlayersByClubId(int clubId) => _context.Players.Where(n => n.ClubId == clubId).ToList();

        public void UpdateClub(Club newClub)
        {
            Club oldClub = GetSingleClubById(newClub.ClubId);
            oldClub.ClubName = newClub.ClubName;
            oldClub.Founded = newClub.Founded;
            _context.SaveChanges();
        }

        public ClubViewModel ClubDeletionConfirmation(int id)
        {

            Club club = GetSingleClubById(id);
            ClubViewModel clubVM = new ClubViewModel()
            {
                ClubId = club.ClubId,
                ClubName = club.ClubName
            };

            return clubVM;

        }

        public ClubViewModel ClubDetails(int id)
        {
            Club club = GetSingleClubById(id);
            ClubViewModel clubVM = new ClubViewModel()
            {
                ClubId = club.ClubId,
                ClubName = club.ClubName,
                Players = GetPlayersByClubId(id)
            };
            return clubVM;

        }
    }
}

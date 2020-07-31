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


        public List<Club> GetAllClubs()
        {
            return _context.Clubs.ToList();
        }

        public void AddClub(Club club)
        {
            _context.Clubs.Add(club);
            _context.SaveChanges();
        }

        public Club GetSingleClubById(int id) => _context.Clubs.Where(n => n.ClubId == id).FirstOrDefault();

        public void UpdateClub(Club newClub)
        {
            Club oldClub = GetSingleClubById(newClub.ClubId);
            oldClub.ClubName = newClub.ClubName;
            oldClub.Founded = newClub.Founded;
            oldClub.StadiumId = newClub.StadiumId;

            _context.SaveChanges();
        }

        public void DeleteClub(int id)
        {
            Club clubToBeDeleted = GetSingleClubById(id);
            _context.Clubs.Remove(clubToBeDeleted);
            _context.SaveChanges();
        }

        public List<Player> GetPlayersByClubId(int clubId) => _context.Players.Where(n => n.ClubId == clubId).ToList();

        public Stadium GetStadiumByStadiumId(int StadiumId) => _context.Stadiums.Where(n => n.StadiumId == StadiumId).FirstOrDefault();

   
        public ClubViewModel ClubDeletionConfirmation(int id)
        {

            Club club = GetSingleClubById(id);
            ClubViewModel clubVM = new ClubViewModel()
            {
                ClubName = club.ClubName,
                Founded = club.Founded,
                Stadium = GetStadiumByStadiumId(club.StadiumId),
                Players = GetPlayersByClubId( club.ClubId )
            };

            return clubVM;

        }

        public ClubViewModel ClubDetails(int id)
        {
            Club club = GetSingleClubById(id);

            ClubViewModel clubVM = new ClubViewModel()
            {
                ClubName = club.ClubName,
                Founded = club.Founded,
                Stadium = GetStadiumByStadiumId(club.StadiumId),
                Players = GetPlayersByClubId(club.ClubId)
            };
            return clubVM;

        }
    }
}

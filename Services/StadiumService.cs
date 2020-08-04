using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Data;
using FootballStarz.Models;
using FootballStarz.ViewModels;

namespace FootballStarz.Services
{
    public class StadiumService : IStadiumService
    {
        private AppDbContext _context;
        public StadiumService(AppDbContext context)
        {
            _context = context;
        }
        public void AddStadium(Stadium stadium)
        {
            _context.Stadiums.Add(stadium);
            _context.SaveChanges();
        }

        public void DeleteStadium(int id)
        {
            Stadium stadiumToBeDeleted = GetSingleStadiumById(id);
            _context.Stadiums.Remove(stadiumToBeDeleted);
            _context.SaveChanges();
        }

        public List<Stadium> GetAllStadiums()
        {
            return _context.Stadiums.ToList();
        }

        public Stadium GetSingleStadiumById(int id) => _context.Stadiums.Where(n => n.StadiumId == id).FirstOrDefault();

        public Club GetSingleClubByClubId(int id) => _context.Clubs.Where(n => n.ClubId == id).FirstOrDefault();

        public List<Stadium> GetStadiumsByClubId(int clubId) => _context.Stadiums.Where(n => n.ClubId == clubId).ToList();


        public void UpdateStadium(Stadium newStadium)
        {
            Stadium oldStadium = GetSingleStadiumById(newStadium.StadiumId);
            oldStadium.StadiumName = newStadium.StadiumName;
            oldStadium.BuildDate = newStadium.BuildDate;
            oldStadium.StadiumImage = newStadium.StadiumImage;
            oldStadium.StadiumId = newStadium.StadiumId;
            _context.SaveChanges();
        }

        public StadiumViewModel StadiumDeletionConfirmation(int id)
        {

            Stadium stadium = GetSingleStadiumById(id);
            StadiumViewModel stadiumVM = new StadiumViewModel()
            {
                StadiumId = stadium.StadiumId,
                StadiumName = stadium.StadiumName
            };

            return stadiumVM;

        }

        public StadiumViewModel StadiumDetails(int id)
        {
            Stadium stadium = GetSingleStadiumById(id);
            Club club = GetSingleClubByClubId(stadium.ClubId);

            StadiumViewModel stadiumVM = new StadiumViewModel()
            {
                StadiumId = stadium.StadiumId,
                StadiumName = stadium.StadiumName,
                Location = stadium.Location,
                BuildDate = stadium.BuildDate,
                StadiumImage= stadium.StadiumImage,
                ClubName = club.ClubName
            };
            return stadiumVM;

        }
    }
}

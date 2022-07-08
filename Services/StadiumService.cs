using System.Collections.Generic;
using System.Linq;
using FootballStarz.Data;
using FootballStarz.Models;
using FootballStarz.ViewModels;
using FootballStarz.Interfaces;
using Microsoft.Extensions.Logging;

namespace FootballStarz.Services
{
    public class StadiumService : IStadiumService
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        public StadiumService(ILogger<StadiumService> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void AddStadium(Stadium stadium)
        {
            _logger.LogInformation($"AddStadium- stadium: {stadium.StadiumName}");

            _context.Stadiums.Add(stadium);
            _context.SaveChanges();
        }

        public void DeleteStadium(int id)
        {
            _logger.LogInformation($"DeleteStadium- id: {id}");

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
            _logger.LogInformation($"UpdateStadium- newStadium: {newStadium.StadiumName}");

            Stadium oldStadium = GetSingleStadiumById(newStadium.StadiumId);
            oldStadium.StadiumName = newStadium.StadiumName;
            oldStadium.BuildDate = newStadium.BuildDate;
            oldStadium.StadiumImage = newStadium.StadiumImage;
            oldStadium.StadiumId = newStadium.StadiumId;
            oldStadium.ClubId = newStadium.ClubId;
            _context.SaveChanges();
        }

        public StadiumViewModel StadiumDeletionConfirmation(int id)
        {
            _logger.LogInformation($"StadiumDeletionConfirmation- id: {id}");

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
            _logger.LogInformation($"StadiumDetails- id: {id}");

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

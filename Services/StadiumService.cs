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
            List<Stadium> stadiums = _context.Stadiums.Include(n => n.School).ToList();
            return stadiums;
        }

        public Stadium GetSingleStadiumById(int id) => _context.Stadiums.Where(n => n.Id == id).FirstOrDefault();

        public List<Player> GetStudentsByStadiumId(int stadiumId) => _context.Students.Where(n => n.StadiumId == stadiumId).ToList();
        

        public void UpdateStadium(Stadium newStadium)
        {
            Stadium oldStadium = GetSingleStadiumById(newStadium.Id);
            oldStadium.FullName = newStadium.FullName;
            oldStadium.Age = newStadium.Age;
            oldStadium.PhoneNumber = newStadium.PhoneNumber;
            oldStadium.YearsOfExperience = newStadium.YearsOfExperience;
            oldStadium.Subject = newStadium.Subject;
            oldStadium.SchoolId = newStadium.SchoolId;
            _context.SaveChanges();
        }

        public StadiumViewModel StadiumDeletionConfirmation(int id)
        {

            Stadium stadium = GetSingleStadiumById(id);
            StadiumViewModel stadiumVM = new StadiumViewModel()
            {
                Id = stadium.Id,
                StadiumName = stadium.FullName
            };

            return stadiumVM;

        }

        public StadiumViewModel StadiumDetails(int id)
        {
            Stadium stadium = GetSingleStadiumById(id);
            StadiumViewModel stadiumVM = new StadiumViewModel()
            {
                StadiumName = stadium.FullName,
                Students = GetStudentsByStadiumId(id)
            };
            return stadiumVM;

        }
    }
}

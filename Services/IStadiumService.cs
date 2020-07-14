using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Models;
using FootballStarz.ViewModels;

namespace FootballStarz.Services
{
    public interface IStadiumService
    {
        List<Stadium> GetAllStadiums();
        void AddStadium(Stadium teacher);
        Stadium GetSingleStadiumById(int id);
        void UpdateStadium(Stadium newTeacher);
        void DeleteStadium(int id);
        List<Stadium> GetStadiumsByClubsId(int teacherId);
        StadiumViewModel StadiumDeletionConfirmation(int id);
        StadiumViewModel StadiumDetails(int id);
        
    }
}

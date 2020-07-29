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
        void AddStadium(Stadium stadium);
        Stadium GetSingleStadiumById(int id);
        void UpdateStadium(Stadium newStadium);
        void DeleteStadium(int id);

        List<Stadium> GetStadiumsByClubId(int clubId);

        Club GetSingleClubByClubId(int clubid);

        StadiumViewModel StadiumDeletionConfirmation(int id);
        StadiumViewModel StadiumDetails(int id);

    }
}

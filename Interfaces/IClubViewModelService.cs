using System;
using System.Collections.Generic;
using FootballStarz.ViewModels;

namespace FootballStarz.Interfaces
{
    public interface IClubViewModelService
    {

        List<ClubViewModel> GetClubs();

        ClubViewModel GetClubDetails(int id);
    }
}

using System;
using System.Collections.Generic;
using FootballStarz.ViewModels;

namespace FootballStarz.VMServiceInterfaces
{
    public interface IClubViewModelService
    {

        List<ClubViewModel> GetClubs();

        ClubViewModel GetClubDetails(int id);
    }
}

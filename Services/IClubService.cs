using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Models;
using FootballStarz.ViewModels;

namespace FootballStarz.Services
{
    public interface IClubService
    {
        List<Club> GetAllClubs();
        void AddClub(Club club);
        Club GetSingleClubById(int id);
        void UpdateClub(Club newClub);
        void DeleteClub(int id);

        List<Player> GetPlayersByClubId(int ClubId);

        Stadium GetStadiumByStadiumId(int StadiumId);

        List<Stadium> GetStadiumsByClubId(int clubId);
        List<Stadium> GetAllStadiums();

        ClubViewModel ClubDeletionConfirmation(int id);

        ClubViewModel ClubDetails(int id);

    }
}

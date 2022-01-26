using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Models;
using FootballStarz.ViewModels;

namespace FootballStarz.Interfaces
{
    public interface IClubService
    {
        List<Club> GetAllClubs();
        List<Stadium> GetAllStadiums();
        List<Player> GetAllPlayers();
        List<String> GetAllClubLogos();

        void AddClub(Club club);
        Club GetSingleClubById(int id);
        void UpdateClub(Club newClub);
        void DeleteClub(int id);

        List<Player> GetPlayersByClubId(int ClubId);

        ClubViewModel ClubDeletionConfirmation(int id);

        Stadium GetStadiumByStadiumId(int stadiumId);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Models;
using FootballStarz.ViewModels;

namespace FootballStarz.Services
{
    public interface IPlayerService
    {
        List<Player> GetAllPlayers();
        void AddPlayer(Player player);
        Player GetSinglePlayerById(int id);
        void UpdatePlayer(Player newPlayer);
        void DeletePlayer(int id);
        PlayerViewModel PlayerDeletionConfirmation(int id);

    }
}

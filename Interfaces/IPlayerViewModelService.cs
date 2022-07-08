using System.Collections.Generic;
using FootballStarz.ViewModels;

namespace FootballStarz.Interfaces
{
    public interface IPlayerViewModelService
    {
        List<PlayerViewModel> GetPlayers();

        List<PlayerViewModel> GetForeignPlayers(string homeNationality);

        PlayerViewModel GetPlayerByPlayerId(int playerId);

    }
}

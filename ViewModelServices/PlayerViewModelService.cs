using FootballStarz.Interfaces;
using FootballStarz.ViewModels;
using FootballStarz.Data;
using System.Collections.Generic;
using FootballStarz.Models;
using FootballStarz.Classes;

namespace FootballStarz.ViewModelServices
{
    public class PlayerViewModelService : IPlayerViewModelService
    {
        private readonly IPlayerService _playerService;

        public PlayerViewModelService(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public PlayerViewModel GetPlayerByPlayerId( int playerId )
        {
           var Player =_playerService.GetSinglePlayerById(playerId);

            var pvm = new PlayerViewModel
            {
                PlayerId = Player.PlayerId,
                PlayerName = Player.PlayerName,
                BirthDate = Player.BirthDate,
                Nationality = Player.Nationality,
                PlayerImage = Player.PlayerImage,
                Club = _playerService.GetSingleClubById(Player.ClubId)
            };

            return pvm;

        }


        public List<PlayerViewModel> GetPlayers( )
        {
            var pvm = new List<PlayerViewModel>();

            var players = _playerService.GetAllPlayers();

  
            foreach(Player player in players)
            {
                pvm.Add(
                    new PlayerViewModel
                    {
                    PlayerId = player.PlayerId,
                    PlayerName = player.PlayerName,
                    BirthDate = player.BirthDate,
                    Nationality = player.Nationality,
                    PlayerImage = player.PlayerImage,
                    Club = _playerService.GetSingleClubById(player.ClubId)
                    }
                );
            }

            return (pvm);
        }

        public List<PlayerViewModel> GetForeignPlayers(string homeNationality)
        {
            var pvm = new List<PlayerViewModel>();

            var players = _playerService.GetForeignPlayers( homeNationality );

            foreach (Player player in players)
            {
                pvm.Add(
                    new PlayerViewModel
                    {
                        PlayerId = player.PlayerId,
                        PlayerName = player.PlayerName,
                        BirthDate = player.BirthDate,
                        Nationality = player.Nationality,
                        PlayerImage = player.PlayerImage,
                        Club = _playerService.GetSingleClubById(player.ClubId)
                    }
                );
            }

            return (pvm);
        }

    }
}

using System.Collections.Generic;
using System.Linq;
using FootballStarz.Data;
using FootballStarz.Models;
using FootballStarz.ViewModels;
using FootballStarz.Interfaces;
using Microsoft.Extensions.Logging;

namespace FootballStarz.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        public PlayerService(ILogger<PlayerService> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public List<Player> GetAllPlayers()
        {
            var Players = _context.Players.ToList();
            return Players;
          
        }

        public List<Player> GetForeignPlayers( string homeNationality)
        {
            var foreigners = from c in _context.Players             // LINQ!
                             where c.Nationality != homeNationality
                             select c;
                
            return foreigners.ToList();
        }

        public void AddPlayer(Player player)
        {
            _logger.LogInformation($"AddPlayer- player: {player.PlayerName}");

            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public void DeletePlayer(int id)
        {
            _logger.LogInformation($"DeletePlayer- id: {id}");

            Player playerToBeDeleted = GetSinglePlayerById(id);
            _context.Players.Remove(playerToBeDeleted);
            _context.SaveChanges();
        }

        public Player GetSinglePlayerById(int playerId) => _context.Players.Where(n => n.PlayerId == playerId).FirstOrDefault();


        public void UpdatePlayer(Player newPlayer)
        {
            _logger.LogInformation($"UpdatePlayer- newPlayer: {newPlayer.PlayerName}");

            Player oldPlayer = GetSinglePlayerById(newPlayer.PlayerId);
            oldPlayer.PlayerName = newPlayer.PlayerName;
            oldPlayer.BirthDate = newPlayer.BirthDate;
            oldPlayer.Nationality = newPlayer.Nationality;
            oldPlayer.PlayerImage = newPlayer.PlayerImage;
            oldPlayer.ClubId = newPlayer.ClubId;
            _context.SaveChanges();
        }

        public PlayerViewModel PlayerDeletionConfirmation(int id)
        {
            _logger.LogInformation($"PlayerDeletionConfirmation- id: {id}");

            Player player = GetSinglePlayerById(id);
            PlayerViewModel playerVM = new PlayerViewModel()
            {
                PlayerId = player.PlayerId,
                PlayerName = player.PlayerName
            };

            return playerVM;

        }

        public Club GetSingleClubById(int id) => _context.Clubs.Where(n => n.ClubId == id).FirstOrDefault();

        public PlayerViewModel PlayerDetails(int id)
        {
            _logger.LogInformation($"PlayerDetails- id: {id}");

            Player player = GetSinglePlayerById(id);
            Club club = GetSingleClubById(player.ClubId);

            PlayerViewModel clubVM = new PlayerViewModel()
            {
                PlayerId = player.PlayerId,
                PlayerName = player.PlayerName,
                BirthDate = player.BirthDate,
                Nationality = player.Nationality,
                PlayerImage = player.PlayerImage,
                Club = club
            };
 
            return clubVM;

        }
    }
}

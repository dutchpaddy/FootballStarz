using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Data;
using FootballStarz.Models;
using FootballStarz.ViewModels;

namespace FootballStarz.Services
{
    public class PlayerService : IPlayerService
    {
        private AppDbContext _context;
        public PlayerService(AppDbContext context)
        {
            _context = context;
        }
        public void AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public void DeletePlayer(int id)
        {
            Player playerToBeDeleted = GetSinglePlayerById(id);
            _context.Players.Remove(playerToBeDeleted);
            _context.SaveChanges();
        }

        public List<Player> GetAllPlayers()
        {
            List<Player> players = _context.Players.Include(n => n.ClubId).ToList();
            return players;
        }

        public Player GetSinglePlayerById(int playerId) => _context.Players.Where(n => n.PlayerId == playerId).FirstOrDefault();



        public void UpdatePlayer(Player newPlayer)
        {
            Player oldPlayer = GetSinglePlayerById(newPlayer.PlayerId);
            oldPlayer.PlayerName = newPlayer.PlayerName;
            oldPlayer.BirthDate = newPlayer.BirthDate;
            oldPlayer.Nationality = newPlayer.Nationality;
            oldPlayer.ClubId = newPlayer.ClubId;
            _context.SaveChanges();
        }

        public PlayerViewModel PlayerDeletionConfirmation(int id)
        {

            Player player = GetSinglePlayerById(id);
            PlayerViewModel playerVM = new PlayerViewModel()
            {
                PlayerId = player.PlayerId,
                PlayerName = player.PlayerName
            };

            return playerVM;

        }
    }
}

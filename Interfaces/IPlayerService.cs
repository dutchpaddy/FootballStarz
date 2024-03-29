﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Models;
using FootballStarz.ViewModels;

namespace FootballStarz.Interfaces
{
    public interface IPlayerService
    {
        List<Player> GetAllPlayers();

        List<Player> GetForeignPlayers(string homeNationality);

        void AddPlayer(Player player);

        Player GetSinglePlayerById(int id);

        Club GetSingleClubById(int id);

        PlayerViewModel PlayerDetails(int id);

        void UpdatePlayer(Player newPlayer);

        void DeletePlayer(int id);

        PlayerViewModel PlayerDeletionConfirmation(int id);

    }
}

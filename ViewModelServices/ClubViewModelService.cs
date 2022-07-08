using System;
using System.Collections.Generic;
using FootballStarz.Data;
using FootballStarz.Interfaces;
using FootballStarz.Models;
using FootballStarz.ViewModels;

namespace FootballStarz.ViewModelServices
{
    public class ClubViewModelService : IClubViewModelService
    {
        private readonly AppDbContext _dbcontext;
        private readonly IClubService _clubservice;

        public ClubViewModelService(
            AppDbContext dbcontext,
            IClubService clubService)
        {
            _dbcontext = dbcontext;
            _clubservice = clubService;
        }

        public List<ClubViewModel> GetClubs()
        {
            var cvm = new List<ClubViewModel>();

            var Clubs = _clubservice.GetAllClubs();

            foreach( Club club in Clubs)
            {
                cvm.Add
                    (new ClubViewModel
                    {
                        ClubId = club.ClubId,
                        ClubName = club.ClubName,
                        Founded = club.Founded,
                        ClubLogo = club.ClubLogo,
                        StadiumId = club.StadiumId,
                        Stadium = _clubservice.GetStadiumByStadiumId(club.StadiumId),
                        Players = _clubservice.GetPlayersByClubId(club.ClubId)
                    }
                    );
            }

            return cvm;
        }

        public ClubViewModel GetClubDetails(int clubId)
        {
//            _logger.LogInformation($"ClubDetails- id: {id}");

            Club club = _clubservice.GetSingleClubById(clubId);
            Stadium stadium = _clubservice.GetStadiumByStadiumId(club.StadiumId);
            List<Player> players = _clubservice.GetPlayersByClubId(club.ClubId);

            ClubViewModel clubVM = new ClubViewModel()
            {
                ClubId = club.ClubId,
                ClubName = club.ClubName,
                Founded = club.Founded,
                ClubLogo = club.ClubLogo,
                Stadium = stadium,
                Players = players
            };

            return clubVM;

        }
    }
}

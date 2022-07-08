using System;
using System.Collections.Generic;
using FootballStarz.Data;
using FootballStarz.Models;
using FootballStarz.Interfaces;
using FootballStarz.ViewModels;

namespace FootballStarz.ViewModelServices
{
    public class StadiumViewModelService : IStadiumViewModelService
    {
        private readonly AppDbContext _dbContext;
        private readonly IStadiumService _stadiumService;

        public StadiumViewModelService(AppDbContext dbContext, IStadiumService stadiumService )
        {
            _dbContext = dbContext;
            _stadiumService = stadiumService;
        }

        public List<StadiumViewModel> GetStadiums()
        {
            var stadiums = _stadiumService.GetAllStadiums();
            var svm = new List<StadiumViewModel>();

            foreach(Stadium stadium in stadiums)
            {
                svm.Add(
                    new StadiumViewModel
                    {
                     StadiumId = stadium.StadiumId,
                     StadiumName = stadium.StadiumName,
                     Location = stadium.Location,
                     BuildDate = stadium.BuildDate,
                     StadiumImage = stadium.StadiumImage,
                     ClubName = _stadiumService.GetSingleClubByClubId(stadium.ClubId).ClubName
                    });
            }

            return svm;
        }
    }
}

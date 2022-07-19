using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using FootballStarz.Models;
using FootballStarz.Interfaces;
using FootballStarz.ViewModels;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace FootballStarz.Controllers
{
    [Authorize]
    public class ClubController : Controller
    {

        private readonly IWebHostEnvironment _HostingEnv;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;

        private readonly IClubViewModelService _clubViewModelService;
        private readonly IClubService _ClubService;
        private readonly IPlayerService _PlayerService;
        private readonly IStadiumService _StadiumService;

        public ClubController(IConfiguration configuration,
                                IWebHostEnvironment HostingEnvironment,
                                ILogger<ClubController> logger,
                                IClubViewModelService clubViewModelService,
                                IClubService ClubService,
                                IPlayerService PlayerService,
                                IStadiumService StadiumService )
        {
            _configuration = configuration;
            _HostingEnv = HostingEnvironment;
            _logger = logger;

            _clubViewModelService = clubViewModelService;
            _ClubService = ClubService;
            _PlayerService = PlayerService;
            _StadiumService = StadiumService;
        }

 //       public IActionResult AllClubs(LoginViewModel LoginVM)
        public IActionResult AllClubs()
        {
            ViewData["ClubMessage"] = "All Clubs are shown here:";

            return View(_clubViewModelService.GetClubs());
        }

        public IActionResult CreateClub()
        {
            ViewBag.Stadiums = _ClubService.GetAllStadiums();

            var ClubVM = new ClubViewModel
            {
                ClubId = 0,
                ClubName = "",
                Founded = new DateTime(),
                ClubLogo = "",
                StadiumId = 0,
                Stadium = new Stadium(),
                Players = new List<Player>()
            };

            return View(ClubVM);
        }

        public IActionResult ClubCreated(Club Club)
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Something went wrong!");
                return View("CreateClub");
            }

            _logger.LogInformation("ClubController- Model state VALID");

            _ClubService.AddClub(Club);

            _logger.LogInformation("ClubController- Club succesfully created.");


            return RedirectToAction("AllClubs");
        }


        public IActionResult EditClub(int Id)
        {
            ViewBag.Stadiums = _StadiumService.GetAllStadiums();

            return View(_ClubService.GetSingleClubById(Id));
        }



        public IActionResult ClubEdited(Club newClub)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Something went wrong!");
                return View("EditClub", newClub);
            }

            _logger.LogInformation("ClubController- Model state VALID");

            _ClubService.UpdateClub(newClub);

            _logger.LogInformation("ClubController- Club succesfully updated.");


           return RedirectToAction("AllClubs");

        }

        public IActionResult DeleteClub(int id) => View(_ClubService.ClubDeletionConfirmation(id));


        public IActionResult ClubDeleted(int id)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Something went wrong!");

                return View("EditClub", _ClubService.GetSingleClubById(id));
            }

            _logger.LogInformation("ClubController- Model state VALID");

            _ClubService.DeleteClub(id);

            _logger.LogInformation("ClubController- Club succesfully deleted.");


            return RedirectToAction("AllClubs");
        }

        public IActionResult ClubDetails(int id)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Something went wrong!");

                return View("EditClub", _ClubService.GetSingleClubById(id));
            }

            _logger.LogInformation("ClubController- Model state VALID; Club succesfully displayed.");

            return View(_clubViewModelService.GetClubDetails(id));

        }
    }
}

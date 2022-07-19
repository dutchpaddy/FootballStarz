using Microsoft.AspNetCore.Mvc;
using FootballStarz.Models;
using FootballStarz.Interfaces;
using FootballStarz.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace FootballStarz.Controllers
{
    [Authorize]
    public class PlayerController : Controller
    {

        private readonly IWebHostEnvironment _HostingEnv;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;

        private readonly IPlayerService _PlayerService;
        private readonly IClubService _ClubService;
        private readonly IPlayerViewModelService _playerViewModelService;

        public PlayerController(IConfiguration configuration,
                                IWebHostEnvironment HostingEnvironment,
                                ILogger<PlayerController> logger,
                                IPlayerService PlayerService,
                                IClubService ClubService,
                                IPlayerViewModelService playerViewModelService)
        {
            _configuration = configuration;
            _HostingEnv = HostingEnvironment;
            _logger = logger;

            _PlayerService = PlayerService;
            _ClubService = ClubService;
            _playerViewModelService = playerViewModelService;
        }

        [AllowAnonymous]
        public IActionResult AllPlayers()
        {
            ViewData["PlayerMessage"] = "All Players are shown here.";
           
            return View(_playerViewModelService.GetPlayers());
            

        }
        public IActionResult AllForeignPlayers()
        {
            ViewData["PlayerMessage"] = "Foreign Players are shown here. [HOME_NATIONALITY="+Constants.HOME_NATIONALITY+"]";

            return View(_playerViewModelService.GetForeignPlayers(Constants.HOME_NATIONALITY));

        }

        public IActionResult CreatePlayer()
        {
            ViewBag.Clubs = _ClubService.GetAllClubs();
            return View();
        }

        public IActionResult PlayerCreated(Player Player)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                return View("CreatePlayer");
            }

            _logger.LogInformation("PlayerController- Model state VALID");

            _PlayerService.AddPlayer(Player);

            _logger.LogInformation("PlayerController- Player succesfully created.");


            return RedirectToAction("AllPlayers");

        }

        public IActionResult EditPlayer(int id)
        {
            ViewBag.Clubs = _ClubService.GetAllClubs();
            return View(_PlayerService.GetSinglePlayerById(id));
        }

        public IActionResult PlayerEdited(Player newPlayer)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                return View("EditPlayer", newPlayer);
            }

            _logger.LogInformation("PlayerController- Model state VALID");

            _PlayerService.UpdatePlayer(newPlayer);

            _logger.LogInformation("PlayerController- Player succesfully updated.");

            return RedirectToAction("AllPlayers");

        }

       

        public IActionResult DeletePlayer(int id) => View(_PlayerService.PlayerDeletionConfirmation(id));


        public IActionResult PlayerDeleted(int id)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                return View("EditPlayer");
            }

            _logger.LogInformation("PlayerController- Model state VALID");

            _PlayerService.DeletePlayer(id);

            _logger.LogInformation("PlayerController- Player succesfully deleted.");

            return RedirectToAction("AllPlayers");


        }

        public IActionResult PlayerDetails(int id)
        {

            //return View(_PlayerService.PlayerDetails(id));
            return View(_playerViewModelService.GetPlayerByPlayerId(id));
        }
    }
}
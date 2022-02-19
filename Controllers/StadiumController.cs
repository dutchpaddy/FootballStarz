using Microsoft.AspNetCore.Mvc;
using FootballStarz.Models;
using FootballStarz.Interfaces;
using FootballStarz.VMServiceInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace FootballStarz.Controllers
{
    [Authorize]
    public class StadiumController : Controller
    {

        private IHostingEnvironment _HostingEnv;
        private IConfiguration _configuration;
        private readonly ILogger _logger;

        private IStadiumService _StadiumService;
        private IClubService _clubService;

        private IStadiumViewModelService _stadiumViewModelService;

        public StadiumController(IConfiguration configuration,
                                IHostingEnvironment HostingEnvironment,
                                ILogger<StadiumController> logger,
                                IStadiumViewModelService stadiumViewModelService,
                                IStadiumService StadiumService,
                                IClubService ClubService)
        {
            _configuration = configuration;
            _HostingEnv = HostingEnvironment;
            _logger = logger;

            _StadiumService = StadiumService;
            _clubService = ClubService;

            _stadiumViewModelService = stadiumViewModelService;
        }

        [AllowAnonymous]
        public IActionResult AllStadiums()
        {
            ViewData["StadiumMessage"] = "All Stadiums are shown here.";
            return View(_stadiumViewModelService.GetStadiums());
        }

        public IActionResult CreateStadium()
        {
            ViewBag.Clubs = _clubService.GetAllClubs();
            return View();
        }

        public IActionResult StadiumCreated(Stadium Stadium)
        {
            if (!ModelState.IsValid)
            {
                      
                ModelState.AddModelError(string.Empty, "Something went wrong:");
                ViewBag.Stadiums = _clubService.GetAllClubs();
                return View("CreateStadium");
            }

            _logger.LogInformation("StadiumController- Model state VALID");

            _StadiumService.AddStadium(Stadium);

            _logger.LogInformation("StadiumController- Stadium succesfully created.");

            return RedirectToAction("AllStadiums");

        }

        public IActionResult EditStadium(int id)
        {
            ViewBag.Clubs = _clubService.GetAllClubs();
            return View(_StadiumService.GetSingleStadiumById(id));
        }

        public IActionResult StadiumEdited(Stadium newStadium)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                ViewBag.Schools = _clubService.GetAllClubs();
                return View("EditStadium", newStadium);
            }

            _logger.LogInformation("Model state VALID");

            _StadiumService.UpdateStadium(newStadium);

            _logger.LogInformation("StadiumController- Stadium succesfully updated.");

            return RedirectToAction("AllStadiums");

        }

        public IActionResult DeleteStadium(int id) => View(_StadiumService.StadiumDeletionConfirmation(id));


        public IActionResult StadiumDeleted(int id)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                ViewBag.Schools = _clubService.GetAllClubs();
                return View("EditStadium", _StadiumService.GetSingleStadiumById(id));
            }

            _logger.LogInformation("Model state VALID");

            _StadiumService.DeleteStadium(id);

            _logger.LogInformation("StadiumController- Stadium succesfully deleted.");

            return RedirectToAction("AllStadiums");
        }

        public IActionResult StadiumDetails(int id)
        {
            return View(_StadiumService.StadiumDetails(id));
        }
    }
}
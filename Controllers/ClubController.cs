using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballStarz.Data;
using FootballStarz.Models;
using FootballStarz.Services;
using FootballStarz.ViewModels;


namespace FootballStarz.Controllers
{
    [Authorize]
    public class ClubController : Controller
    {

        private IClubService _ClubService;
        private IPlayerService _PlayerService;
        public ClubController(IClubService ClubService, IPlayerService PlayerService)
        {
            _ClubService = ClubService;
            _PlayerService = PlayerService;
        }
        [AllowAnonymous]
        public IActionResult AllClubs()
        {
            return View(_ClubService.GetAllClubs());
        }
        public IActionResult CreateClub()
        {
            ViewBag.Stadiums = _ClubService.GetAllStadiums();
            return View();
        }

        public IActionResult ClubCreated(Club Club)
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Something went wrong!");
                return View("CreateClub");
            }
            _ClubService.AddClub(Club);
            return View();
        }


        public IActionResult EditClub(int id)
        {
            ViewBag.Stadiums = _ClubService.GetAllStadiums();
            return View(_ClubService.GetSingleClubById(id));
        }



        public IActionResult ClubEdited(Club newClub)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Something went wrong!");
                return View("EditClub", newClub);
            }
            _ClubService.UpdateClub(newClub);

            return View();

        }

        public IActionResult DeleteClub(int id) => View(_ClubService.ClubDeletionConfirmation(id));


        public IActionResult ClubDeleted(int id)
        {
            _ClubService.DeleteClub(id);
            return View();
        }

        public IActionResult ClubDetails(int id)
        {

            return View(_ClubService.ClubDetails(id));
        }

        [Route("/search/{name}")]
        public IActionResult Search(string name)
        {
            string searchName = name;
            return View();
        }
    }
}

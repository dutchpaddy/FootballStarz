using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FootballStarz.Models;
using FootballStarz.Data;
using FootballStarz.ViewModels;
using Microsoft.EntityFrameworkCore;
using FootballStarz.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace FootballStarz.Controllers
{
    [Authorize]
    public class PlayerController : Controller
    {

        private IPlayerService _PlayerService;
        private IClubService _ClubService;
        public PlayerController(IPlayerService PlayerService, IClubService ClubService)
        {
            _PlayerService = PlayerService;
            _ClubService = ClubService;
        }
        [AllowAnonymous]
        public IActionResult AllPlayers()
        {
                return View(_PlayerService.GetAllPlayers());
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
            _PlayerService.AddPlayer(Player);
            return View();
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
            _PlayerService.UpdatePlayer(newPlayer);
            return View();

        }

        public IActionResult DeletePlayer(int id) => View(_PlayerService.PlayerDeletionConfirmation(id));

        public IActionResult PlayerDeleted(int id)
        {
            _PlayerService.DeletePlayer(id);
            return View();

        }

        public IActionResult PlayerDetails(int id)
        {

            return View(_PlayerService.PlayerDetails(id));
        }

        [Route("/search/{name}")]
        public IActionResult Search(string name)
        {
            string searchName = name;
            return View();
        }
    }
}
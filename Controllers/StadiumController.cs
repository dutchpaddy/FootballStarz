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
    public class StadiumController : Controller
    {
        private IStadiumService _StadiumService;
        private IClubService _clubService;
        public StadiumController(IStadiumService StadiumService, IClubService ClubService)
        {
            _StadiumService = StadiumService;
            _clubService = ClubService;

        }

        [AllowAnonymous]
        public IActionResult AllStadiums()
        {
            return View(_StadiumService.GetAllStadiums());
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
                ModelState.AddModelError(string.Empty, "Something went wrong");
                ViewBag.Stadiums = _clubService.GetAllClubs();
                return View("CreateStadium");
            }
            _StadiumService.AddStadium(Stadium);
            return View();
        }
        public IActionResult EditStadium(int id)
        {
            ViewBag.Schools = _clubService.GetAllClubs();
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
            _StadiumService.UpdateStadium(newStadium);
            return View();

        }

        public IActionResult DeleteStadium(int id) => View(_StadiumService.StadiumDeletionConfirmation(id));

        public IActionResult StadiumDeleted(int id)
        {
            _StadiumService.DeleteStadium(id);

            return View();
        }
        public IActionResult StadiumDetails(int id)
        {
            return View(_StadiumService.StadiumDetails(id));
        }
    }
}
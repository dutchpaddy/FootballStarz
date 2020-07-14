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
    public class SchoolController : Controller
    {

        private IClubService _schoolService;
        public SchoolController(IClubService schoolService)
        {
            _schoolService = schoolService;
        }
        [AllowAnonymous]
        public IActionResult All()
        {
            return View(_schoolService.GetAllSchools());
        }
        public IActionResult CreateSchool() => View();
        public IActionResult SchoolCreated(Club school)
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Something went wrong!");
                return View("CreateSchool");
            }
            _schoolService.AddSchool(school);
            return View();
        }


        public IActionResult EditSchool(int id) => View(_schoolService.GetSingleSchoolById(id));


        public IActionResult SchoolEdited(Club newSchool)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Something went wrong!");
                return View("EditSchool", newSchool);
            }
            _schoolService.UpdateSchool(newSchool);

            return View();

        }

        public IActionResult DeleteSchool(int id) => View(_schoolService.SchoolDeletionConfirmation(id));


        public IActionResult SchoolDeleted(int id)
        {
            _schoolService.DeleteSchool(id);
            return View();
        }

        public IActionResult SchoolDetails(int id)
        {

            return View(_schoolService.SchoolDetails(id));
        }

        [Route("/search/{name}")]
        public IActionResult Search(string name)
        {
            string searchName = name;
            return View();
        }
    }
}

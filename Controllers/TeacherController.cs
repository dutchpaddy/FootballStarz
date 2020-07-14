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
    public class TeacherController : Controller
    {
        private IStadiumService _teacherService;
        private IClubService _schoolService;
        public TeacherController(IStadiumService teacherService, IClubService schoolService)
        {
            _teacherService = teacherService;
            _schoolService = schoolService;

        }

        [AllowAnonymous]
        public IActionResult AllTeachers()
        {
            return View(_teacherService.GetAllTeachers());
        }
        public IActionResult CreateTeacher()
        {
            ViewBag.Schools = _schoolService.GetAllSchools();
            return View();
        }
        public IActionResult TeacherCreated(Stadium teacher)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                ViewBag.Schools = _schoolService.GetAllSchools();
                return View("CreateTeacher");
            }
            _teacherService.AddTeacher(teacher);
            return View();
        }
        public IActionResult EditTeacher(int id)
        {
            ViewBag.Schools = _schoolService.GetAllSchools();
            return View(_teacherService.GetSingleTeacherById(id));
        }
        public IActionResult TeacherEdited(Stadium newTeacher)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                ViewBag.Schools = _schoolService.GetAllSchools();
                return View("EditTeacher", newTeacher);
            }
            _teacherService.UpdateTeacher(newTeacher);
            return View();

        }

        public IActionResult DeleteTeacher(int id) => View(_teacherService.TeacherDeletionConfirmation(id));

        public IActionResult TeacherDeleted(int id)
        {
            _teacherService.DeleteTeacher(id);

            return View();
        }
        public IActionResult TeacherDetails(int id)
        {
            return View(_teacherService.TeacherDetails(id));
        }
    }
}
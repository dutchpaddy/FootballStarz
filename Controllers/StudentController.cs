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
    public class StudentController : Controller
    {

        private IPlayerService _studentService;
        private IStadiumService _teacherService;
        public StudentController(IPlayerService studentService, IStadiumService teacherService)
        {
            _studentService = studentService;
            _teacherService = teacherService;
        }
        [AllowAnonymous]
        public IActionResult AllStudents()
        {
                return View(_studentService.GetAllStudents());
        }

            public IActionResult CreateStudent()
        {
            ViewBag.Teachers = _teacherService.GetAllTeachers();
            return View();
        }
        public IActionResult StudentCreated(Player student)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Teachers = _teacherService.GetAllTeachers();
                ModelState.AddModelError(string.Empty, "Something went wrong");
                return View("CreateStudent");
            }
            _studentService.AddStudent(student);
            return View();
        }
        public IActionResult EditStudent(int id)
        {
            ViewBag.Teachers = _teacherService.GetAllTeachers();
            return View(_studentService.GetSingleStudentById(id));
        }
        public IActionResult StudentEdited(Player newStudent)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Something went wrong");
                ViewBag.Teachers = _teacherService.GetAllTeachers();
                return View("EditStudent", newStudent);
            }
            _studentService.UpdateStudent(newStudent);
            return View();

        }

        public IActionResult DeleteStudent(int id) => View(_studentService.StudentDeletionConfirmation(id));


        public IActionResult StudentDeleted(int id)
        {
            _studentService.DeleteStudent(id);
            return View();

        }
    }
}
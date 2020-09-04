using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using validatingFormSubmission.Models;

namespace validatingFormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("user/create")]
        public IActionResult Create(User newUser)
        {
            Console.WriteLine("***************************");
            if (ModelState.IsValid)
            {
                // User newUser = new User();
                // newUser.First_Name = First_Name;
                // newUser.Last_Name = Last_Name;
                // newUser.Age = Age;
                // newUser.Email = Email;
                // newUser.Password = Password;
                return RedirectToAction("Registered");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("registered")]
        public IActionResult Registered()
        {
            return View();
        }
    }
}

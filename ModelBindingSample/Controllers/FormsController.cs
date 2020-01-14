using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingSample.Models;

namespace ModelBindingSample.Controllers
{
    public class FormsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// When user clicks submit and sends form data, ie post to server.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(IFormCollection data)
        {
            // Validate all form data

            // Map data to C# Student object
            Student s = new Student();
            s.FullName = data["full-name"];
            s.DateOfBirth = Convert.ToDateTime(data["dob"]);
            s.FavoriteNumber = Convert.ToInt16(data["fav-num"]);

            // Add to database

            // Success Message
            ViewData["Message"] = "Student Added Successfully";

            return View();
        }
    }
}
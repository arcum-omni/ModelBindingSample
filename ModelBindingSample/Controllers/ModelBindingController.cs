using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBindingSample.Models;

namespace ModelBindingSample.Controllers
{
    public class ModelBindingController : Controller
    {
        [HttpGet] // Default, Not Required
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student s)
        {
            // ensures model is in a valid state
            if(ModelState.IsValid)
            {
                // add to the database
                
                return RedirectToAction("Index", "Home");
            }
            else // validation problems
            {
                // return view with errors
                return View();

                // return View(s);
                // You CAN pass the model back to the view
                // but this is now done automatically
            }
        }
    }
}
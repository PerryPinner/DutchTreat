﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet ("contact")]
        public IActionResult Contact()
        {
           
            return View();
        }
        [HttpPost ("contact")]
        public IActionResult Contact(ViewModels.ContactViewModel model)
        {
            
            return View();
        }

        public IActionResult About ()
        {
            ViewBag.Title = "About Us";
            return View();

        }
    }
}

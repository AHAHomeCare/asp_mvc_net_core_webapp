﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASP.Net_MVC_Core.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication;
using ASP.Net_MVC_Core.Migrations;
using Microsoft.AspNetCore.Authorization;

namespace ASP.Net_MVC_Core.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           // TempData["data_menu"] = "Hello Data";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


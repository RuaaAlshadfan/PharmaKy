﻿using Microsoft.AspNetCore.Mvc;
using Pharma_Ky.Models;
using System.Diagnostics;

namespace Pharma_Ky.Controllers
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
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Detalis()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Delivery()
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
﻿using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;

namespace IMS_Project.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
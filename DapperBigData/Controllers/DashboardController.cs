﻿using Microsoft.AspNetCore.Mvc;

namespace DapperBigData.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

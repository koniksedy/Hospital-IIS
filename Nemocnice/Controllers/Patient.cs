﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nemocnice.Controllers
{
    public class Patient : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
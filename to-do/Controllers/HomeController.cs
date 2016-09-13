﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace to_do.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult About()
    {
      ViewData["Message"] = "About.";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Contact.";

      return View();
    }

    public IActionResult Error()
    {
      return View();
    }
  }
}

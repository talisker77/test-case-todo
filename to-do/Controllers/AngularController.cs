﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace to_do.Controllers
{
  public class AngularController : Controller
  {
    // GET: /<controller>/
    public IActionResult Index()
    {
      return View();
    }
    public IActionResult Main()
    {
      return View();
    }

    public IActionResult UserRegister()
    {
      return View();
    }

    public IActionResult ToDoList()
    {
      return View();
    }

    public IActionResult ToDoTypes()
    {
      return View();
    }

    public IActionResult Reports()
    {
      return View();
    }
  }
}

﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Dammon.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public LoginController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

   
}

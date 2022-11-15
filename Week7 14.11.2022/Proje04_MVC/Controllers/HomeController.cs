﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Proje04_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        string ad = "Sefa";
        ViewBag.kisiAd=ad;
        string dil ="Tr";
        string selamlama = "";
        if (dil=="Tr")
        {
            selamlama="Hoşgeldiniz";
        }
        else if (dil=="En")
        {
            selamlama="Welcome";
        }
        else
        {
            selamlama="";
        }
        ViewBag.selam=selamlama;
        return View();
    }
}

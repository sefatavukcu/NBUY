using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Proje04_MVC.Controllers;

public class Category{
    public string Name { get; set; }
}
public class Product{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class HomeController : Controller
{
    public IActionResult Index()
    {
        string ad = "Sefa";
        ViewBag.kisiAd=ad;
        string dil ="En";
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
    public IActionResult About()
    {
        ViewBag.Hata=true;
        ViewData["Not"]=75;
        List<string> adlar = new List<string>(){"Sema","Harun","Sefa","Tuğçe"};
        ViewData["Adlar"]=adlar;

        List<string> bolumler = new List<string>(){"İnsan Kaynakları","Muhasebe","Eğitim","Satış"};
        ViewBag.Bolumler=bolumler;
        return View();
    }
    public IActionResult GetProducts()
    {
        List<Product> products = new List<Product>(){
            new Product(){Id=1,Name="IPhone 13",Price=24000},
            new Product(){Id=2,Name="IPhone 14",Price=34000},
            new Product(){Id=3,Name="IPhone 15",Price=44000},
            new Product(){Id=4,Name="IPhone 16",Price=54000},
            new Product(){Id=5,Name="IPhone 17",Price=64000}
        };
        //ViewBag.Products=products;
        return View(products);
    }
    public IActionResult GetCategories()
    {
        List<Category> categories = new List<Category>(){
            new Category(){Name="Telefon"},
            new Category(){Name="Bilgisayar"},
            new Category(){Name="Beyaz Eşya"},
        };
        return View(categories);
    }
}

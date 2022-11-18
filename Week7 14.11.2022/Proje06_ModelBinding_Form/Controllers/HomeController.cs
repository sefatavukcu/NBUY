using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje06_ModelBinding_Form.Models;

namespace Proje06_ModelBinding_Form.Controllers;
// Tipi belirtilmemiş methodlar get (default)
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    // bu mesela get
    public IActionResult YasGrubu()
    {
        return View();
    }

    // YasGrubu(int yas) post grubunda bir method
    [HttpPost]
    public IActionResult YasGrubu(int yas, string ad)
    {
        if (yas==0)
        {
            ViewBag.YasGrubu="Lütfen bir yaş giriniz.";
        }
        else if (yas<18)
        {
            ViewBag.YasGrubu=$"{ad}, reşit değilsin!";
        }
        else if (yas<40)
        {
            ViewBag.YasGrubu=$"{ad}, gençsin";
        }
        else if (yas<60)
        {
            ViewBag.YasGrubu=$"{ad}, yaşlısın!";
        }
        else
        {
            ViewBag.YasGrubu=$"{ad}, Allah rahmet eylesin!";
        }

        return View();
    }

    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateProduct(Product product, bool IsApproved)
    {
        // Burada veritabanına kayıt işlemi yapılacak...
        // Şimdilik gelen verilerin testini yapabilmek için sayfaya bastırıyoruz.
        // ViewBag.ResultHeader=$"{productName} adlı ürün eklendi.";
        // ViewBag.ResultBody=$"Category: {productCategory}, Price: {productPrice}";
        return View(product);
    }

    // public IActionResult VerileriAl(string txtAd, int txtYas)
    // {
    //     return View();
    // }
}   
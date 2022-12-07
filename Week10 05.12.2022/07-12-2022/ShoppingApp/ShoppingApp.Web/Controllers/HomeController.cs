﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly IProductService _productManager;

    public HomeController(IProductService productManager)
    {
        _productManager = productManager;
    }

    public async Task<IActionResult> Index() // Task= asenkron çalışabilmesi için parça parça ayrı bir iş vermek gerekiyor.
    {
        List<Product> products = await _productManager.GetAllAsync();
        List<ProductDto> productDtos= new List<ProductDto>();
        foreach (var product in products)
        {
            productDtos.Add(new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                DateAdded = product.DateAdded
            });
        }
        return View(productDtos);
    }
}

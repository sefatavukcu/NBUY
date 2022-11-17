using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace KitabeviApp.Controllers
{
 
    public class AdminController : Controller
    {
        public IActionResult Category_Index()
        {
            MyDbContext context = new MyDbContext();
            List<Category> categories = context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Author_Index()
        {
            MyDbContext context = new MyDbContext();
            List<Author> authors = context.Authors.ToList();
            return View(authors);
        }
        public IActionResult Book_Index()
        {
            MyDbContext context = new MyDbContext();
            List<Book> books = context.Books.Include(p=> p.Category).Include(p=> p.Author).ToList();
            return View(books);
        }
    }
}
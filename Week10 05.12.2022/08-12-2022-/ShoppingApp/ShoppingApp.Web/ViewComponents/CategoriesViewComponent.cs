using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;

namespace ShoppingApp.Web.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        // Viewbag ile categorileri göndermek için oluşturduk.
        private readonly ICategoryService _categoryManager;

        public CategoriesViewComponent(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (RouteData.Values["category"] != null)
            {
                ViewBag.SelectedCategory = RouteData.Values["category"];
            }
            var categories = await _categoryManager.GetAllAsync();
            return View(categories);
        }

        
    }
}
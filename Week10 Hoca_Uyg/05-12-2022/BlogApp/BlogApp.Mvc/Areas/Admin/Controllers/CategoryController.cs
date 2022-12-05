﻿using BlogApp.Entities.Dtos;
using BlogApp.Mvc.Areas.Admin.Models;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Extensions;
using BlogApp.Shared.Utilities.Result.ComplexTypes;
using BlogApp.Shared.Utilities.Result.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlogApp.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        public async Task<IActionResult> Index()
        {
            var result = await _categoryService.GetAllByNonDeleted();
            if (result.ResultStatus==ResultStatus.Success)
            {
                return View(result.Data);
            }
            return View();
        }
        public IActionResult Add()
        {
            return PartialView("_CategoryAddPartial");
        }
        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryService.Add(categoryAddDto,"Engin Niyazi");
                if (result.ResultStatus==ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
                    {
                        CategoryDto = result.Data,
                        CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddPartial", categoryAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new CategoryAddAjaxViewModel
            {
                CategoryAddPartial = await this.RenderViewToStringAsync("_CategoryAddPartial", categoryAddDto)
            });
            return Json(categoryAddAjaxErrorModel);
        }
        
        public async Task<JsonResult> GetAllCategories() // yenile butonu ile sayfa yenilenmeden sadece kategori tablosu yenilenecek. Şimdilik GetAll kullanıyoruz. Daha sonra başka metot kullanılacak.
        {
            var result = await _categoryService.GetAllByNonDeleted(); // category serviceden tüm kategorileri çağır
            var resultJson = JsonSerializer.Serialize(result.Data, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(resultJson);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(int categoryId) // delete butonunun işlemleri
        {
            var result = await _categoryService.Delete(categoryId, "Sefa Tavukcu"); //categoryservice den silinen id ve kimin sildiği (delete komutuna gitti)
            var resultJson = JsonSerializer.Serialize(result);
            return Json(resultJson);
        }
    }
}
// jquery sayfanın herhangi bir kısmında düzenleme yapılacağı zaman kullanılır. (Ajax)
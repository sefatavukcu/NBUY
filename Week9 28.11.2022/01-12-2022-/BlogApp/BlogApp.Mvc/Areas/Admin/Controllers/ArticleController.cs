using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Result.ComplexTypes;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task<IActionResult> Index() // task ile asenkron yapılıyor.
        {
            var result = await _articleService.GetAll(); // category service gidip bütün kategorileri çeker ve result değişkenine atar.
            if (result.ResultStatus==ResultStatus.Success) //result.Status ResultStatus.Success ise onunla birlikte gelen datayı view ile gönderip eğer data gelmemişse boş olarak gönderir.
            {
                return View(result.Data);
            }
            return View();
        }
    }
}

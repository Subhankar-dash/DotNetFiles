using Microsoft.AspNetCore.Mvc;
using MVCCore_OAS3Client.Models;
using System.Diagnostics;
using ClientNS;
using System.Text.Json;

namespace MVCCore_OAS3Client.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HttpClient client = null;
        string baseUrl = string.Empty;
        ClientProxy proxy = null;
        public CategoryController(ILogger<HomeController> logger)
        {
            _logger = logger;
            baseUrl = "https://localhost:7021/";
            client = new HttpClient();
            proxy = new ClientProxy(baseUrl, client);
        }

        public async Task<IActionResult> Index(int id)
        {
            if(id == 0)
            {
                var result = await proxy.GetcategotiesAsync();
                ViewBag.Categories = result;
                return View();
            }
            else
            {
                //var result = proxy.GetSubCatAsync(id);
                var result = (await proxy.GetSubCatAsync()).ToList().Where(sb => sb.id == id);
                ViewBag.subcategory = result;
                return View("ProductView");
                
            }
           
        }

        [HttpPost]
        public async Task<IActionResult> Index(CategoryProd category)
        {
           /* var result = proxy.GetSubCatAsync(category.CategoryId);

            ViewBag.subcategory = result;*/

            return RedirectToAction("Index",new { id=category.CategoryId});
        }
        //[HttpPost]
        //public async Task<IActionResult> Index(SubCategoryProd subcategory)
        //{
        //    var result = proxy.
        //    ViewBag.subcategory = result;

        //    return View();
        //}
    }
}

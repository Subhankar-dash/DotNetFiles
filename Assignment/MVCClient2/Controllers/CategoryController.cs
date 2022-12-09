using Microsoft.AspNetCore.Mvc;
using MVCClient2.Models;
using System.Diagnostics;
using ClientNS;
using System.Text.Json;
using MVCClient2.Controllers;

namespace MVCClient2.Controllers
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


        public async Task<IActionResult> Index()
        {
            var result = await proxy.GetcategotiesAsync();
            ViewBag.Categories = result;
            return View();
        }


       [HttpPost]
        public async Task<IActionResult> Index(CategoryProd id)
        {
            
                var Subcat = (await proxy.GetsubcategoriessAsync()).ToList();


            var SunCategorytList = new List<SubCategory>();


            var products = (await proxy.GetProductsAsync()).ToList();



            foreach (var sub in Subcat)
            {
                
                    if (sub.CategoryId == id.CategoryId)
                    {
                    SunCategorytList.Add(sub);
                    }
                
            }




                var productList = new List<Product>();

                foreach (var sub in Subcat)
                {
                    foreach (var prod in products)
                    {
                        if (prod.SubCategoryId == sub.SubCategoryId)
                        {
                            productList.Add(prod);
                        }
                    }
                }
               ViewBag.Products = productList;
                return View("ProductView");

            

        }

        //[HttpPost]
        //public async Task<IActionResult> Index(CategoryProd category)
        //{
        //    /* var result = proxy.GetSubCatAsync(category.CategoryId);

        //     ViewBag.subcategory = result;*/

        //    return RedirectToAction("Index", new { id = category.CategoryId });
        //}
        //[HttpPost]
        //public async Task<IActionResult> Index(SubCategoryProd subcategory)
        //{
        //    var result = proxy.
        //    ViewBag.subcategory = result;

        //    return View();
        //}
    }
}

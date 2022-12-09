using Microsoft.AspNetCore.Mvc;
using MySearchMVC.Models;
using MySearchMVC.Services;
using MySearchMVC.DataAccess;

namespace MySearchMVC.Controllers
{
    public class SController : Controller
    {


        iserv<ProductDetail> productDetailService;

        public SController(iserv<ProductDetail> productDetailService)
        {
            this.productDetailService = productDetailService;
        }


        public IActionResult Se()
        {

            return View();

        }

        [HttpPost]
        public IActionResult Se(string? searchTerm)
        {
            
                var prod = productDetailService.Searching(searchTerm);
                return View(prod);
            
            
        }
    }
}

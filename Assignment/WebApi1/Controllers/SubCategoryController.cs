using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi1.Models;
using WebApi1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiController]
    public class SubCategoryController : Controller
    {
        IDbAccessService<SubCategory, int> sub ;
        public SubCategoryController(IDbAccessService<SubCategory, int> sub)
        {
            this.sub = sub;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/GetSubCat/{id}")]
        public async Task<IActionResult> GetSubCat(int id)
        {
            var result = await sub.GetAsync(id);
            return Ok(result);
        }

        [HttpGet("/getsubcategoriess")]
        public async Task<IEnumerable<SubCategory>> GetSubCategory()
        {
            var result = await sub.GetAsync();
            return result;
        }

        [HttpGet]
        public async Task<IActionResult> GetSub()
        {
            var result = await sub.GetAsync();
            return Ok(result);
        }
    }
}

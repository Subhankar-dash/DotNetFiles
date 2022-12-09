using WebApi1.Models;
using WebApi1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{





    [Route("api/[controller]")]
    [ApiController]
    public class CreateBothAPIController : ControllerBase
    {

        IBothCreate<Category, Product> bothCreate;

        public CreateBothAPIController(IBothCreate<Category, Product> BothCreate)
        {
            this.bothCreate = BothCreate;
        }




        [HttpPost]
        public async Task<IActionResult> CreateBoth([FromQuery]Category category, Product product)
        {


            Console.WriteLine("hfgfjg");
            var result = await bothCreate.CreateBothAsync(category, product);
            return Ok() ;
        }
    }






}

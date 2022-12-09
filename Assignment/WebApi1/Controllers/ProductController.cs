using WebApi1.Models;
using WebApi1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;

namespace APIApps.Controllers
{
   
    [Route("api/[controller]")]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IDbAccessService<Product, int> prodService;
        
        public ProductController(IDbAccessService<Product, int> service)
        {
            prodService = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await prodService.GetAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await prodService.GetAsync(id);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Product prod)
        {
            var result = await prodService.CreateAsync(prod);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Product prod)
        {
            var result = await prodService.UpdateAsync(id, prod);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await prodService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpGet("/GetProductSRC/{id}")]
        public async Task<IActionResult> GetProdasync(int id)
        {
            var result = await prodService.GetAsync(id);

            return Ok(result);
        }
        [HttpGet("/getProducts")]
        public async Task<IEnumerable<Product>> GetSubCategory()
        {
            var result = await prodService.GetAsync();
            return result ;
        }
    }






}
using Microsoft.AspNetCore.Mvc;
using MVP1.Entity;
using MCP1.Reposetery;
using System.Runtime.InteropServices;
using DataAccess.Models;
using MVCApps.Models;
using MVCApps.CustomFilter;
using MVCApps.CustomSessionExtensions;

namespace MVC_Apps.Controllers
{
    /// <summary>
    /// Apply Filter at Controller
    /// </summary>
    /// 
    //[LogRequest]
    public class CategoryController : Controller
    {
        IDbRepository<Category, int> catRepo;
        /// <summary>
        /// Ijecting the Depednency
        /// </summary>
        /// <param name="ctaRepo"></param>
        public CategoryController(IDbRepository<Category, int> catRepo)
        {
            this.catRepo = catRepo;
        }

        /// <summary>
        /// Apply Filter at Action Method
        /// </summary>
        /// <returns></returns>
        /// 
       // [LogRequest]
        public async Task<IActionResult> Index()
        {
            try
            {
                var records = await catRepo.GetAsync();
                // THis will return an Index.cshtml View from
                // Category Sub-Folder of the Views folder
                // and pass the records (Categories) to it
                return View(records);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }


        public async Task<IActionResult> IndexTagHelper()
        {
            try
            {
                var records = await catRepo.GetAsync();

                return View(records);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        public async Task<IActionResult> Create()
        {
            var category = new Category();
            if (HttpContext.Session.GetObject<Category>("Session") != null )
            {
                category = HttpContext.Session.GetObject<Category>("Session");
                ViewBag.ErrorMessage = HttpContext.Session.GetString("ErrorMessage");
            }
            HttpContext.Session.Clear();
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            //try
            //{
            //    var respose = await catRepo.CreateAsync(category);
            //    // Return to Index Action Method in Same
            //    // Controller
            //    return RedirectToAction("Index");
            //}
            //catch (Exception ex)
            //{

            //    throw;
            //}

            //try
            //{
            if (ModelState.IsValid)
            {
                if (category.BasePrice < 0)
                {
                    HttpContext.Session.SetObject<Category>("Session", category);
                    HttpContext.Session.SetString("ErrorMessage", "base price cannot be -ve");
                    throw new Exception("base price cannot be -ve");
                }
                var respose = await catRepo.CreateAsync(category);

                // Return to Index Action Method in Same
                // Controller
                return RedirectToAction("Index");
            }
            else
            {
                // Stay on Same View
                // THis will Show Error Messages
                return View(category);
            }

            //}
            //catch (Exception ex)
            //{
            //    return View("Error", new ErrorViewModel() 
            //    {
            //        //ControllerName = "Category",
            //        //ActonName = "Create",
            //        //ErrorMessage = ex.Message
            //        // REad controller and action from RouteData
            //        ControllerName = this.RouteData.Values["controller"].ToString(),
            //        ActonName = this.RouteData.Values["action"].ToString(),
            //        ErrorMessage = ex.Message
            //    });
            //}

        }


        public async Task<IActionResult> Edit(int id)
        {
            var record = await catRepo.GetAsync(id);
            return View(record);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            try
            {
                var result = await catRepo.UpdateAsync(id, category);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IActionResult> ShowDetails(int id)
        {
            // Save the 'id' isn Session State
            //   HttpContext.Session.SetInt32("CategoryId", id);

            // HttpContext.Session.SetInt32("CategoryId", id);

            // Using The TempData
            TempData["CategoryId"] = id;

            // Save Entity Object in Session
            var category = await catRepo.GetAsync(id);
            HttpContext.Session.SetObject<Category>("Cat", category);

            // Redirect to the ProductController and its Index Method
            return RedirectToAction("Index", "Product");

        }

    }
}
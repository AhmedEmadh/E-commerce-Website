using E_commerce_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_Website.Controllers
{
    public class ProductsController : Controller
    {
        ECommerceWebsiteContext db;
        public ProductsController(ECommerceWebsiteContext mydb)
        {
            db = mydb;
        }
        public IActionResult Index()
        {
            var CatList = db.Categories.ToList();
            // create select list to show categories in dropdown list
            ViewBag.CatList = new SelectList(CatList, "Id", "Name");
            return View();
        }

        public IActionResult Create(ProductVM model)
        {
            if (ModelState.IsValid)
            {
                // Use CategoryName from the form, which can be a new or existing category
                Category? category = db.Categories.FirstOrDefault(c => c.Name == model.CategoryName);
                if (category == null)
                {
                    category = new Category { Name = model.CategoryName };
                }
                db.Add(new Product { Name = model.ProductName, Price = model.Price, Quantity = model.Quantity, Category = category });
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            // Repopulate category list for redisplay
            var CatList = db.Categories.ToList();
            ViewBag.CatList = new SelectList(CatList, "Id", "Name");
            return View("Index", model);
        }
    }
}

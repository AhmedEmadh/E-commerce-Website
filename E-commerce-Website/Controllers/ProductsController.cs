using E_commerce_Website.Models;
using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
        public IActionResult Create(ProductVM model)
        {
            if (ModelState.IsValid)
            {
                Category? category = db.Categories.FirstOrDefault(c => c.Name == model.CategoryName);
                if (category == null)
                {
                    category = new Category { Name = model.CategoryName };
                }
                db.Add(new Product { Name = model.ProductName, Price = model.Price, Category = category });
                db.SaveChanges();
                return View("Index");
            }
            return View("Index", model);
        }
    }
}

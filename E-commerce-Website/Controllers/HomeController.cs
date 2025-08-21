using System.Diagnostics;
using E_commerce_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        ECommerceWebsiteContext db = new ECommerceWebsiteContext();
        public IActionResult Index()
        {
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Products = db.Products.ToList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Categories()
        {

            var categories = db.Categories.ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Products(int? id)
        {
            List<Product> products;
            if (id != null)
            {
                products = db.Products.Where(p => p.CategoryId == id).Include(product => product.Category).ToList();

            }
            else
            {
                products = db.Products.Include(product => product.Category).ToList();
            }
            if(products.Count <= 0)
            {
                return NotFound();
            }
            return View(products);
        }
        [HttpGet]
        public IActionResult SearchProduct(string name)
        {
            var products = db.Products
                             .Where(x => x.Name.Contains(name)).Include(product => product.Category)
                             .ToList();

            return View(products);
        }
        [HttpPost]
        public IActionResult SendReview(ReviewVM reviewVM)
        {

            db.Reviews.Add(new Review { Name = reviewVM.name, Email = reviewVM.email, Subject = reviewVM.subject, Description = reviewVM.message });
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

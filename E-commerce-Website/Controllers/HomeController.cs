using System.Diagnostics;
using E_commerce_Website.Models;
using Microsoft.AspNetCore.Mvc;

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

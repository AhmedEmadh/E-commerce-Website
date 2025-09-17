using System.Diagnostics;
using E_commerce_Website.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        UserManager<IdentityUser> _userManager;
        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }
        ECommerceWebsiteContext db = new ECommerceWebsiteContext();
        public IActionResult Index()
        {
            IndexDM indexDM = new IndexDM();
            indexDM.Categories = db.Categories.ToList();
            indexDM.Products = db.Products.ToList();
            indexDM.RecentProducts = db.Products.OrderByDescending(p => p.DateAdded).Take(3).ToList();
            indexDM.Reviews = db.Reviews.ToList();
            return View(indexDM);
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
                products = db.Products.Include(p=>p.Carts).Where(p => p.CategoryId == id).Include(product => product.Category).ToList();

            }
            else
            {
                products = db.Products.Include(p => p.Carts).Include(product => product.Category).ToList();
            }
            if (products.Count <= 0)
            {
                return NotFound();
            }
            return View(products);
        }
        [HttpGet]
        public IActionResult SearchProduct(string name)
        {
            List<Product> products = new List<Product>();
            if (!string.IsNullOrEmpty(name))
            {
                products = db.Products.Include(p => p.Carts)
                                .Where(x => x.Name.Contains(name)).Include(product => product.Category)
                                .ToList();
            }
            else
            {
                products = db.Products.Include(p=>p.Carts).Include(product => product.Category).ToList();
            }

            return View(products);
        }
        [HttpPost]
        public IActionResult SendReview(ReviewVM reviewVM)
        {

            db.Reviews.Add(new Review { Name = reviewVM.name, Email = reviewVM.email, Subject = reviewVM.subject, Description = reviewVM.message });
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult CurrentProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product? product = db.Products.Include(p => p.Category).Include(product => product.ProductImages).FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [Authorize(Roles = "visitor")]
        public async Task<IActionResult> Cart()
        {
            List<Cart> carts = new List<Cart>();
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                carts = db.Carts.Include(c=>c.Product).Where(c => c.UserId == user.Id).ToList();
                ViewBag.TotalPrice = carts.Sum(c=>(c.Quantity)*(c.Product.Price));
                return View(carts);
            }
            return View(carts);
        }
        [Authorize]
        public async Task<IActionResult> AddProductToCart(int id)
        {

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("index");
            }
            var cart = db.Carts.Include(c => c.Product).FirstOrDefault(c => c.ProductId == id);
            if (cart == null)
            {
                db.Add(new Cart { ProductId = id, UserId = user.Id, Quantity = 1, });
            }
            else
            {
                if (cart.Quantity + 1 <= cart.Product.Quantity)
                {
                    cart.Quantity += 1;
                }
            }
            db.SaveChanges();
            if (TempData["CurrentPage"]?.ToString() == "Home")
            {
                // Redirect to HomeController → Index action
                return RedirectToAction("Index", "Home");
            }
            else if (TempData["CurrentPage"]?.ToString() == "Product")
            {
                // Redirect to HomeController → Products action
                return RedirectToAction("Products", "Home");
            }
            else
            {
                return RedirectToAction("SearchProduct", "Home");
            }
        }
        public IActionResult DeleteProductFromCart(int id)
        {
            var carts = db.Carts.Where(c => c.ProductId == id);
            db.Carts.RemoveRange(carts);
            db.SaveChanges();
            return RedirectToAction("Cart");
        }
        [HttpPost]
        [Authorize(Roles = "visitor")]
        public IActionResult UpdateCartQuantity(int cartId, int quantity)
        {
            var cart = db.Carts.Include(c => c.Product).FirstOrDefault(c => c.Id == cartId);
            if (cart != null && quantity > 0 && quantity <= cart.Product.Quantity)
            {
                cart.Quantity = quantity;
                db.SaveChanges();
            }
            return RedirectToAction("Cart");
        }
        [Authorize(Roles = "visitor")]
        public IActionResult AddOrder(OrderVM model)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.GetUserAsync(User).Result;
                if (user == null)
                {
                    return RedirectToAction("index");
                }
                var carts = db.Carts.Include(c => c.Product).Where(c => c.UserId == user.Id).ToList();
                if (carts.Count > 0)
                {
                    // Check stock before placing order
                    foreach (var cart in carts)
                    {
                        if (cart.Product.Quantity < cart.Quantity)
                        {
                            TempData["CartError"] = $"Not enough stock for product: {cart.Product.Name}. Available: {cart.Product.Quantity}, Requested: {cart.Quantity}";
                            return RedirectToAction("Cart");
                        }
                    }

                    Order order = new Order
                    {
                        Name = model.Name,
                        Address = model.Address,
                        Email = model.Email,
                        Phone = model.Phone,
                        UserId = user.Id,
                        TotalPrice = carts.Sum(c => (c.Quantity) * (c.Product.Price)),
                    };
                    db.Orders.Add(order);
                    db.SaveChanges(); // Save order to generate order.Id

                    foreach (var cart in carts)
                    {
                        var product = db.Products.FirstOrDefault(p => p.Id == cart.ProductId);
                        if (product != null)
                        {
                            product.Quantity -= cart.Quantity;
                            if (product.Quantity < 0) product.Quantity = 0; // Prevent negative stock
                        }
                        OrderDetail orderDetail = new OrderDetail
                        {
                            OrderId = order.Id,
                            ProductId = cart.ProductId,
                            Quantity = cart.Quantity,
                            Price = (decimal)cart.Product.Price,
                            UserId = user.Id // Set UserId to avoid null
                        };
                        db.OrderDetails.Add(orderDetail);
                    }
                    db.Carts.RemoveRange(carts);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Cart");
        }
        [Authorize(Roles = "visitor")]
        public IActionResult Orders()
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return RedirectToAction("index");
            }
            var orders = db.Orders.Where(o => o.UserId == user.Id).ToList();
            return View(orders);
        }
        [Authorize(Roles = "visitor")]
        public IActionResult OrderDetails(int id)
        {
            var user = _userManager.GetUserAsync(User).Result;
            if (user == null)
            {
                return RedirectToAction("index");
            }
            var order = db.Orders.Include(o => o.OrderDetails)
                                 .ThenInclude(od => od.Product)
                                 .FirstOrDefault(o => o.Id == id && o.UserId == user.Id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

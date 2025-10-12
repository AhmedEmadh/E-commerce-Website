using System.Diagnostics;
using System.Threading.Tasks;
using E_commerce_Website.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
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
                products = db.Products.Include(p => p.Carts).Where(p => p.CategoryId == id).Include(product => product.Category).ToList();

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
        public async Task<IActionResult> SearchProduct(string name)
        {
            //Get Current User
            var user = await _userManager.GetUserAsync(User);
            //Get List of All Products
            List<Product> products = new List<Product>();
            if (!string.IsNullOrEmpty(name))
            {
                //If Search Keyword is not empty => filter by search word
                products = db.Products.Include(p => p.Carts)
                                .Where(x => x.Name.Contains(name)).Include(product => product.Category)
                                .ToList();
            }
            else
            {
                //If Search keyword is empty => Just show all products
                products = db.Products.Include(p => p.Carts.Where(c => user != null && (c.UserId == user.Id))).Include(product => product.Category).ToList();
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
                carts = db.Carts.Include(c => c.Product).Where(c => c.UserId == user.Id).ToList();
                ViewBag.TotalPrice = carts.Sum(c => (c.Quantity) * (c.Product.Price));
                return View(carts);
            }
            return View(carts);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AddProductToCartApi(int id)
        {
            // Get the current user
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Unauthorized(new { message = "User not logged in" });
            }

            // Get the product
            var product = await db.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new { message = "The product was not found" });
            }

            if (product.Quantity <= 0)
            {
                return BadRequest(new { message = "The product is out of stock" });
            }

            // Check if product is already in the cart
            var cart = await db.Carts.FirstOrDefaultAsync(c => c.UserId == user.Id && c.ProductId == product.Id);

            if (cart == null)
            {
                await db.Carts.AddAsync(new Cart { ProductId = product.Id, UserId = user.Id });
            }
            else
            {
                return Conflict(new { message = "The product is already in the cart" });
            }

            var result = await db.SaveChangesAsync();
            if (result > 0)
            {
                return Ok(new { message = "Product added to cart successfully" });
            }
            else
            {
                return StatusCode(500, new { message = "An error occurred, the product was not added to the cart." });
            }
        }
        [Authorize]
        public async Task<IActionResult> AddProductToCart(int id)
        {
            //Get Current User
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("index");
            }
            //Get Product with id
            var product = db.Products.FirstOrDefault(p => p.Id == id);
            if (product == null || product.Quantity <= 0)
            {
                //If product not found or out of stock show (out of stock)
                TempData["CartError"] = "This product is out of stock and cannot be added to the cart.";
                return RedirectToAction("Cart");
            }
            //Find Cart item for current product and current user
            var cart = db.Carts.Include(c => c.Product).FirstOrDefault(c => c.ProductId == id && c.UserId == user.Id);
            if (cart != null)
            {
                // if there is cart item for the product direct to the cart without showing any message
                return RedirectToAction("Cart");
            }
            //if there is no cart item for the current product => Add the current product to the cart
            db.Add(new Cart { ProductId = id, UserId = user.Id, Quantity = 1 });
            db.SaveChanges();
            if (TempData["CurrentPage"]?.ToString() == "Home")
            {
                return RedirectToAction("Index", "Home");
            }
            else if (TempData["CurrentPage"]?.ToString() == "Product")
            {
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

using Serenity.Navigation;
using MyPages = AdminPanel.ECommerceWebsite.Pages;

[assembly: NavigationLink(int.MaxValue, "ECommerceWebsite/Carts", typeof(MyPages.CartsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ECommerceWebsite/Categories", typeof(MyPages.CategoriesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ECommerceWebsite/Product Images", typeof(MyPages.ProductImagesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ECommerceWebsite/Products", typeof(MyPages.ProductsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ECommerceWebsite/Reviews", typeof(MyPages.ReviewsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ECommerceWebsite/Order", typeof(MyPages.OrderPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ECommerceWebsite/Order Details", typeof(MyPages.OrderDetailsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ECommerceWebsite/Asp Net Users", typeof(MyPages.AspNetUsersPage), icon: null)]
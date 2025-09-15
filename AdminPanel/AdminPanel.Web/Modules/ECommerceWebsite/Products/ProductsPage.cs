using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.ECommerceWebsite.Pages;

[PageAuthorize(typeof(ProductsRow))]
public class ProductsPage : Controller
{
    [Route("ECommerceWebsite/Products")]
    public ActionResult Index()
    {
        return this.GridPage<ProductsRow>("@/ECommerceWebsite/Products/ProductsPage");
    }
}
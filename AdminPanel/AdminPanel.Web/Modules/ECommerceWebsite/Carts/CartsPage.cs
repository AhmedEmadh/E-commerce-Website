using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.ECommerceWebsite.Pages;

[PageAuthorize(typeof(CartsRow))]
public class CartsPage : Controller
{
    [Route("ECommerceWebsite/Carts")]
    public ActionResult Index()
    {
        return this.GridPage<CartsRow>("@/ECommerceWebsite/Carts/CartsPage");
    }
}
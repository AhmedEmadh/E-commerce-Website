using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.ECommerceWebsite.Pages;

[PageAuthorize(typeof(OrderRow))]
public class OrderPage : Controller
{
    [Route("ECommerceWebsite/Order")]
    public ActionResult Index()
    {
        return this.GridPage<OrderRow>("@/ECommerceWebsite/Order/OrderPage");
    }
}
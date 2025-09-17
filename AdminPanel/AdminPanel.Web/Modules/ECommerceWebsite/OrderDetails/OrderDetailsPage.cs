using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.ECommerceWebsite.Pages;

[PageAuthorize(typeof(OrderDetailsRow))]
public class OrderDetailsPage : Controller
{
    [Route("ECommerceWebsite/OrderDetails")]
    public ActionResult Index()
    {
        return this.GridPage<OrderDetailsRow>("@/ECommerceWebsite/OrderDetails/OrderDetailsPage");
    }
}
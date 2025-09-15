using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.ECommerceWebsite.Pages;

[PageAuthorize(typeof(ProductImagesRow))]
public class ProductImagesPage : Controller
{
    [Route("ECommerceWebsite/ProductImages")]
    public ActionResult Index()
    {
        return this.GridPage<ProductImagesRow>("@/ECommerceWebsite/ProductImages/ProductImagesPage");
    }
}
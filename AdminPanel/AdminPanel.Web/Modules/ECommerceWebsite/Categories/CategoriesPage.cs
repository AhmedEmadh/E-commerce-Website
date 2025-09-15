using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.ECommerceWebsite.Pages;

[PageAuthorize(typeof(CategoriesRow))]
public class CategoriesPage : Controller
{
    [Route("ECommerceWebsite/Categories")]
    public ActionResult Index()
    {
        return this.GridPage<CategoriesRow>("@/ECommerceWebsite/Categories/CategoriesPage");
    }
}
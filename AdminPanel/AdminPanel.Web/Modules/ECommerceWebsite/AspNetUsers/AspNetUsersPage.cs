using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.ECommerceWebsite.Pages;

[PageAuthorize(typeof(AspNetUsersRow))]
public class AspNetUsersPage : Controller
{
    [Route("ECommerceWebsite/AspNetUsers")]
    public ActionResult Index()
    {
        return this.GridPage<AspNetUsersRow>("@/ECommerceWebsite/AspNetUsers/AspNetUsersPage");
    }
}
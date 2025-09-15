using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace AdminPanel.ECommerceWebsite.Pages;

[PageAuthorize(typeof(ReviewsRow))]
public class ReviewsPage : Controller
{
    [Route("ECommerceWebsite/Reviews")]
    public ActionResult Index()
    {
        return this.GridPage<ReviewsRow>("@/ECommerceWebsite/Reviews/ReviewsPage");
    }
}
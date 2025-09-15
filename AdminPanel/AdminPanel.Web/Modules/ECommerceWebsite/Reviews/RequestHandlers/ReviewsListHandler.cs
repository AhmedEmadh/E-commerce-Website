using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.ECommerceWebsite.ReviewsRow>;
using MyRow = AdminPanel.ECommerceWebsite.ReviewsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IReviewsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IReviewsListHandler
{
    public ReviewsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
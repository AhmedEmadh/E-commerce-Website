using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel.ECommerceWebsite.ReviewsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IReviewsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IReviewsDeleteHandler
{
    public ReviewsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
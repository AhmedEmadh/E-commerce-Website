using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.ECommerceWebsite.ReviewsRow>;
using MyRow = AdminPanel.ECommerceWebsite.ReviewsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IReviewsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewsRetrieveHandler
{
    public ReviewsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
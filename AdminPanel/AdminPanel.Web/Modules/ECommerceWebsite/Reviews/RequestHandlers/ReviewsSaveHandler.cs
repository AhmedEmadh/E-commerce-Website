using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.ECommerceWebsite.ReviewsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.ECommerceWebsite.ReviewsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IReviewsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ReviewsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IReviewsSaveHandler
{
    public ReviewsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
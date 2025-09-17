using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.ECommerceWebsite.AspNetUsersRow>;
using MyRow = AdminPanel.ECommerceWebsite.AspNetUsersRow;

namespace AdminPanel.ECommerceWebsite;

public interface IAspNetUsersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AspNetUsersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAspNetUsersRetrieveHandler
{
    public AspNetUsersRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
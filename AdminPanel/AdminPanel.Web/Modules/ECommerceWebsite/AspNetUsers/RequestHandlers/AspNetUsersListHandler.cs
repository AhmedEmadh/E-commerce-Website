using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.ECommerceWebsite.AspNetUsersRow>;
using MyRow = AdminPanel.ECommerceWebsite.AspNetUsersRow;

namespace AdminPanel.ECommerceWebsite;

public interface IAspNetUsersListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AspNetUsersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAspNetUsersListHandler
{
    public AspNetUsersListHandler(IRequestContext context)
            : base(context)
    {
    }
}
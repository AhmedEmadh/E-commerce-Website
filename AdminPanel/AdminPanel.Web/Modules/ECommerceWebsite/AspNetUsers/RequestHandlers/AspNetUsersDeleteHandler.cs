using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel.ECommerceWebsite.AspNetUsersRow;

namespace AdminPanel.ECommerceWebsite;

public interface IAspNetUsersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AspNetUsersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAspNetUsersDeleteHandler
{
    public AspNetUsersDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
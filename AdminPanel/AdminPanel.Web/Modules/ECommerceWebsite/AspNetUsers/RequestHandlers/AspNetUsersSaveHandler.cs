using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.ECommerceWebsite.AspNetUsersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.ECommerceWebsite.AspNetUsersRow;

namespace AdminPanel.ECommerceWebsite;

public interface IAspNetUsersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AspNetUsersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAspNetUsersSaveHandler
{
    public AspNetUsersSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
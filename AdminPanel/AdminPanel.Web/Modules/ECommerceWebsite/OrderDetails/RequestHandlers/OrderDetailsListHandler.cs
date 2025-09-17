using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.ECommerceWebsite.OrderDetailsRow>;
using MyRow = AdminPanel.ECommerceWebsite.OrderDetailsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IOrderDetailsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsListHandler
{
    public OrderDetailsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
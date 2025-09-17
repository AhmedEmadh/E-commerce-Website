using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.ECommerceWebsite.OrderRow>;
using MyRow = AdminPanel.ECommerceWebsite.OrderRow;

namespace AdminPanel.ECommerceWebsite;

public interface IOrderListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class OrderListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IOrderListHandler
{
    public OrderListHandler(IRequestContext context)
            : base(context)
    {
    }
}
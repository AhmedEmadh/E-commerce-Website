using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.ECommerceWebsite.OrderRow>;
using MyRow = AdminPanel.ECommerceWebsite.OrderRow;

namespace AdminPanel.ECommerceWebsite;

public interface IOrderRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class OrderRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderRetrieveHandler
{
    public OrderRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.ECommerceWebsite.OrderDetailsRow>;
using MyRow = AdminPanel.ECommerceWebsite.OrderDetailsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IOrderDetailsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsRetrieveHandler
{
    public OrderDetailsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
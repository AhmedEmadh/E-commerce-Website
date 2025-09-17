using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.ECommerceWebsite.OrderDetailsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.ECommerceWebsite.OrderDetailsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IOrderDetailsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsSaveHandler
{
    public OrderDetailsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
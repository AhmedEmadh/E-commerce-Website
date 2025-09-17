using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.ECommerceWebsite.OrderRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.ECommerceWebsite.OrderRow;

namespace AdminPanel.ECommerceWebsite;

public interface IOrderSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class OrderSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IOrderSaveHandler
{
    public OrderSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
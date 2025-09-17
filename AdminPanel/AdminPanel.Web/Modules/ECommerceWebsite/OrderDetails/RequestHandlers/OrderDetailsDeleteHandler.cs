using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel.ECommerceWebsite.OrderDetailsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IOrderDetailsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class OrderDetailsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IOrderDetailsDeleteHandler
{
    public OrderDetailsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
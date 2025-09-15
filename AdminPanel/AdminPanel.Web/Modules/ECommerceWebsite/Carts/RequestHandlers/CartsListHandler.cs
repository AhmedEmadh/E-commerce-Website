using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.ECommerceWebsite.CartsRow>;
using MyRow = AdminPanel.ECommerceWebsite.CartsRow;

namespace AdminPanel.ECommerceWebsite;

public interface ICartsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CartsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICartsListHandler
{
    public CartsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel.ECommerceWebsite.CartsRow;

namespace AdminPanel.ECommerceWebsite;

public interface ICartsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CartsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICartsDeleteHandler
{
    public CartsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
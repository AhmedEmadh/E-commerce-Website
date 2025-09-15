using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.ECommerceWebsite.CartsRow>;
using MyRow = AdminPanel.ECommerceWebsite.CartsRow;

namespace AdminPanel.ECommerceWebsite;

public interface ICartsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CartsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICartsRetrieveHandler
{
    public CartsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
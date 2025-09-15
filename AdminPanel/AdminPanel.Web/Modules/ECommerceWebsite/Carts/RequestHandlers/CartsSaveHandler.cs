using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.ECommerceWebsite.CartsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.ECommerceWebsite.CartsRow;

namespace AdminPanel.ECommerceWebsite;

public interface ICartsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CartsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICartsSaveHandler
{
    public CartsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
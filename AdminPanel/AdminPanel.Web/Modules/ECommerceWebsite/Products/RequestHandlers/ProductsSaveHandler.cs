using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.ECommerceWebsite.ProductsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.ECommerceWebsite.ProductsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IProductsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductsSaveHandler
{
    public ProductsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
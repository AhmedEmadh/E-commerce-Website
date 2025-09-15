using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.ECommerceWebsite.ProductsRow>;
using MyRow = AdminPanel.ECommerceWebsite.ProductsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IProductsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductsRetrieveHandler
{
    public ProductsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
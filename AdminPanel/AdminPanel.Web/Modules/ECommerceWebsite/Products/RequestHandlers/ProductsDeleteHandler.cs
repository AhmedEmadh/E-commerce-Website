using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel.ECommerceWebsite.ProductsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IProductsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ProductsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductsDeleteHandler
{
    public ProductsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
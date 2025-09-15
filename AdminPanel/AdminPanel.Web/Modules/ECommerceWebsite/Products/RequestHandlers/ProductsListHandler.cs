using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.ECommerceWebsite.ProductsRow>;
using MyRow = AdminPanel.ECommerceWebsite.ProductsRow;

namespace AdminPanel.ECommerceWebsite;

public interface IProductsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProductsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductsListHandler
{
    public ProductsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
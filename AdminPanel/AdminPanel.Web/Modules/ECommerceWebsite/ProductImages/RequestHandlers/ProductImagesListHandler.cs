using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.ECommerceWebsite.ProductImagesRow>;
using MyRow = AdminPanel.ECommerceWebsite.ProductImagesRow;

namespace AdminPanel.ECommerceWebsite;

public interface IProductImagesListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagesListHandler
{
    public ProductImagesListHandler(IRequestContext context)
            : base(context)
    {
    }
}
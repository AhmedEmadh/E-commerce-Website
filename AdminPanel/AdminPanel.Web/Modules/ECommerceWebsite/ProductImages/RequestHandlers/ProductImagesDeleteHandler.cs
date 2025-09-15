using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdminPanel.ECommerceWebsite.ProductImagesRow;

namespace AdminPanel.ECommerceWebsite;

public interface IProductImagesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagesDeleteHandler
{
    public ProductImagesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
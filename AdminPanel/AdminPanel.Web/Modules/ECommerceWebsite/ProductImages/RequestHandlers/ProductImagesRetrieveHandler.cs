using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.ECommerceWebsite.ProductImagesRow>;
using MyRow = AdminPanel.ECommerceWebsite.ProductImagesRow;

namespace AdminPanel.ECommerceWebsite;

public interface IProductImagesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagesRetrieveHandler
{
    public ProductImagesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
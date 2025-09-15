using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.ECommerceWebsite.ProductImagesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.ECommerceWebsite.ProductImagesRow;

namespace AdminPanel.ECommerceWebsite;

public interface IProductImagesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProductImagesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductImagesSaveHandler
{
    public ProductImagesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
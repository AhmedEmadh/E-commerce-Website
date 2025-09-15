using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.ECommerceWebsite.CategoriesRow>;
using MyRow = AdminPanel.ECommerceWebsite.CategoriesRow;

namespace AdminPanel.ECommerceWebsite;

public interface ICategoriesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CategoriesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesRetrieveHandler
{
    public CategoriesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
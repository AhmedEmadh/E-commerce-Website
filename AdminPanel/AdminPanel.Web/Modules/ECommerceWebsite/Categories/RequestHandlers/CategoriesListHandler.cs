using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdminPanel.ECommerceWebsite.CategoriesRow>;
using MyRow = AdminPanel.ECommerceWebsite.CategoriesRow;

namespace AdminPanel.ECommerceWebsite;

public interface ICategoriesListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CategoriesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesListHandler
{
    public CategoriesListHandler(IRequestContext context)
            : base(context)
    {
    }
}
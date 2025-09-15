using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdminPanel.ECommerceWebsite.CategoriesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.ECommerceWebsite.CategoriesRow;

namespace AdminPanel.ECommerceWebsite;

public interface ICategoriesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CategoriesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesSaveHandler
{
    public CategoriesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
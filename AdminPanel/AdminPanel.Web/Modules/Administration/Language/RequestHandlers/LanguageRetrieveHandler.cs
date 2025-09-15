using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdminPanel.Administration.LanguageRow>;
using MyRow = AdminPanel.Administration.LanguageRow;

namespace AdminPanel.Administration;
public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>(context), ILanguageRetrieveHandler
{
}
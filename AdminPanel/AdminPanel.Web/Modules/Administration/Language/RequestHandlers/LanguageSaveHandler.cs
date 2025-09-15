using MyRequest = Serenity.Services.SaveRequest<AdminPanel.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.Administration.LanguageRow;

namespace AdminPanel.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageSaveHandler(IRequestContext context)
    : SaveRequestHandler<MyRow, MyRequest, MyResponse>(context), ILanguageSaveHandler
{
}
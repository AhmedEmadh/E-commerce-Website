using MyRequest = Serenity.Services.SaveRequest<AdminPanel.Administration.RoleRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdminPanel.Administration.RoleRow;

namespace AdminPanel.Administration;
public interface IRoleSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class RoleSaveHandler(IRequestContext context)
    : SaveRequestHandler<MyRow, MyRequest, MyResponse>(context), IRoleSaveHandler
{
    protected override void InvalidateCacheOnCommit()
    {
        base.InvalidateCacheOnCommit();

        Cache.InvalidateOnCommit(UnitOfWork, UserPermissionRow.Fields);
        Cache.InvalidateOnCommit(UnitOfWork, RolePermissionRow.Fields);
    }
}
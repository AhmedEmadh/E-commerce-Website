import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AspNetUsersColumns, AspNetUsersRow, AspNetUsersService } from '../../ServerTypes/ECommerceWebsite';
import { AspNetUsersDialog } from './AspNetUsersDialog';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.AspNetUsersGrid')
export class AspNetUsersGrid extends EntityGrid<AspNetUsersRow> {
    protected getColumnsKey() { return AspNetUsersColumns.columnsKey; }
    protected getDialogType() { return AspNetUsersDialog; }
    protected getRowDefinition() { return AspNetUsersRow; }
    protected getService() { return AspNetUsersService.baseUrl; }
}
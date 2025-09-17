import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AspNetUsersForm, AspNetUsersRow, AspNetUsersService } from '../../ServerTypes/ECommerceWebsite';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.AspNetUsersDialog')
export class AspNetUsersDialog extends EntityDialog<AspNetUsersRow, any> {
    protected getFormKey() { return AspNetUsersForm.formKey; }
    protected getRowDefinition() { return AspNetUsersRow; }
    protected getService() { return AspNetUsersService.baseUrl; }

    protected form = new AspNetUsersForm(this.idPrefix);
}
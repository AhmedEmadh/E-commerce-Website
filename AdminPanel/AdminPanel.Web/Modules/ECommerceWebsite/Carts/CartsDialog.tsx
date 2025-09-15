import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CartsForm, CartsRow, CartsService } from '../../ServerTypes/ECommerceWebsite';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.CartsDialog')
export class CartsDialog extends EntityDialog<CartsRow, any> {
    protected getFormKey() { return CartsForm.formKey; }
    protected getRowDefinition() { return CartsRow; }
    protected getService() { return CartsService.baseUrl; }

    protected form = new CartsForm(this.idPrefix);
}
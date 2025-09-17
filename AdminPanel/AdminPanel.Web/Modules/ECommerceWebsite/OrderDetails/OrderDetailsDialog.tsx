import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { OrderDetailsForm, OrderDetailsRow, OrderDetailsService } from '../../ServerTypes/ECommerceWebsite';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.OrderDetailsDialog')
export class OrderDetailsDialog extends EntityDialog<OrderDetailsRow, any> {
    protected getFormKey() { return OrderDetailsForm.formKey; }
    protected getRowDefinition() { return OrderDetailsRow; }
    protected getService() { return OrderDetailsService.baseUrl; }

    protected form = new OrderDetailsForm(this.idPrefix);
}
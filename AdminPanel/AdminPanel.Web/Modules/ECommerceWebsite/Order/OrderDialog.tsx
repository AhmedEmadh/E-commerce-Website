﻿import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { OrderForm, OrderRow, OrderService } from '../../ServerTypes/ECommerceWebsite';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.OrderDialog')
export class OrderDialog extends EntityDialog<OrderRow, any> {
    protected getFormKey() { return OrderForm.formKey; }
    protected getRowDefinition() { return OrderRow; }
    protected getService() { return OrderService.baseUrl; }

    protected form = new OrderForm(this.idPrefix);
}
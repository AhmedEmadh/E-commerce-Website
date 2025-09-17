import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { OrderColumns, OrderRow, OrderService } from '../../ServerTypes/ECommerceWebsite';
import { OrderDialog } from './OrderDialog';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.OrderGrid')
export class OrderGrid extends EntityGrid<OrderRow> {
    protected getColumnsKey() { return OrderColumns.columnsKey; }
    protected getDialogType() { return OrderDialog; }
    protected getRowDefinition() { return OrderRow; }
    protected getService() { return OrderService.baseUrl; }
}
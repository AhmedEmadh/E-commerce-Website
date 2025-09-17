import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { OrderDetailsColumns, OrderDetailsRow, OrderDetailsService } from '../../ServerTypes/ECommerceWebsite';
import { OrderDetailsDialog } from './OrderDetailsDialog';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.OrderDetailsGrid')
export class OrderDetailsGrid extends EntityGrid<OrderDetailsRow> {
    protected getColumnsKey() { return OrderDetailsColumns.columnsKey; }
    protected getDialogType() { return OrderDetailsDialog; }
    protected getRowDefinition() { return OrderDetailsRow; }
    protected getService() { return OrderDetailsService.baseUrl; }
}
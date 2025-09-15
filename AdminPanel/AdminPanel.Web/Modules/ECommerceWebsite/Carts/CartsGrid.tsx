import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CartsColumns, CartsRow, CartsService } from '../../ServerTypes/ECommerceWebsite';
import { CartsDialog } from './CartsDialog';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.CartsGrid')
export class CartsGrid extends EntityGrid<CartsRow> {
    protected getColumnsKey() { return CartsColumns.columnsKey; }
    protected getDialogType() { return CartsDialog; }
    protected getRowDefinition() { return CartsRow; }
    protected getService() { return CartsService.baseUrl; }
}
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CategoriesColumns, CategoriesRow, CategoriesService } from '../../ServerTypes/ECommerceWebsite';
import { CategoriesDialog } from './CategoriesDialog';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.CategoriesGrid')
export class CategoriesGrid extends EntityGrid<CategoriesRow> {
    protected getColumnsKey() { return CategoriesColumns.columnsKey; }
    protected getDialogType() { return CategoriesDialog; }
    protected getRowDefinition() { return CategoriesRow; }
    protected getService() { return CategoriesService.baseUrl; }
}
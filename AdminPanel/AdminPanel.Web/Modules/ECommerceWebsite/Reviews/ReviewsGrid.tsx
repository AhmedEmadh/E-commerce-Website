import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ReviewsColumns, ReviewsRow, ReviewsService } from '../../ServerTypes/ECommerceWebsite';
import { ReviewsDialog } from './ReviewsDialog';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.ReviewsGrid')
export class ReviewsGrid extends EntityGrid<ReviewsRow> {
    protected getColumnsKey() { return ReviewsColumns.columnsKey; }
    protected getDialogType() { return ReviewsDialog; }
    protected getRowDefinition() { return ReviewsRow; }
    protected getService() { return ReviewsService.baseUrl; }
}
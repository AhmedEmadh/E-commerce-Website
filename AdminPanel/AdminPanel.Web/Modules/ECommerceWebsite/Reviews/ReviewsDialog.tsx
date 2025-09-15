import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ReviewsForm, ReviewsRow, ReviewsService } from '../../ServerTypes/ECommerceWebsite';

@Decorators.registerClass('AdminPanel.ECommerceWebsite.ReviewsDialog')
export class ReviewsDialog extends EntityDialog<ReviewsRow, any> {
    protected getFormKey() { return ReviewsForm.formKey; }
    protected getRowDefinition() { return ReviewsRow; }
    protected getService() { return ReviewsService.baseUrl; }

    protected form = new ReviewsForm(this.idPrefix);
}
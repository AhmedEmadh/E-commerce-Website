import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ReviewsForm {
    Name: StringEditor;
    Email: StringEditor;
    Subject: StringEditor;
    Description: StringEditor;
}

export class ReviewsForm extends PrefixedContext {
    static readonly formKey = 'ECommerceWebsite.Reviews';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ReviewsForm.init)  {
            ReviewsForm.init = true;

            var w0 = StringEditor;

            initFormType(ReviewsForm, [
                'Name', w0,
                'Email', w0,
                'Subject', w0,
                'Description', w0
            ]);
        }
    }
}
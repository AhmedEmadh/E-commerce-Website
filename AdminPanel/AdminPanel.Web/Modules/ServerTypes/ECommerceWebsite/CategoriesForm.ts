import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CategoriesForm {
    Name: StringEditor;
    Description: StringEditor;
    Photo: StringEditor;
}

export class CategoriesForm extends PrefixedContext {
    static readonly formKey = 'ECommerceWebsite.Categories';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriesForm.init)  {
            CategoriesForm.init = true;

            var w0 = StringEditor;

            initFormType(CategoriesForm, [
                'Name', w0,
                'Description', w0,
                'Photo', w0
            ]);
        }
    }
}
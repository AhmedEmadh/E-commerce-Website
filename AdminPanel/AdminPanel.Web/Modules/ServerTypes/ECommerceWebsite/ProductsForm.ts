import { StringEditor, DecimalEditor, ServiceLookupEditor, ImageUploadEditor, DateEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ProductsForm {
    Name: StringEditor;
    Description: StringEditor;
    Price: DecimalEditor;
    CategoryId: ServiceLookupEditor;
    Photo: ImageUploadEditor;
    DateAdded: DateEditor;
    Quantity: IntegerEditor;
}

export class ProductsForm extends PrefixedContext {
    static readonly formKey = 'ECommerceWebsite.Products';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductsForm.init)  {
            ProductsForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = ServiceLookupEditor;
            var w3 = ImageUploadEditor;
            var w4 = DateEditor;
            var w5 = IntegerEditor;

            initFormType(ProductsForm, [
                'Name', w0,
                'Description', w0,
                'Price', w1,
                'CategoryId', w2,
                'Photo', w3,
                'DateAdded', w4,
                'Quantity', w5
            ]);
        }
    }
}
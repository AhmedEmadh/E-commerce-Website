import { ServiceLookupEditor, ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ProductImagesForm {
    ProductId: ServiceLookupEditor;
    Image: ImageUploadEditor;
}

export class ProductImagesForm extends PrefixedContext {
    static readonly formKey = 'ECommerceWebsite.ProductImages';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductImagesForm.init)  {
            ProductImagesForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = ImageUploadEditor;

            initFormType(ProductImagesForm, [
                'ProductId', w0,
                'Image', w1
            ]);
        }
    }
}
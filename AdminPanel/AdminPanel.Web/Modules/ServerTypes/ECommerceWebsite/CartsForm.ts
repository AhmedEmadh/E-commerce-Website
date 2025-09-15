import { StringEditor, ServiceLookupEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CartsForm {
    UserId: StringEditor;
    ProductId: ServiceLookupEditor;
    Quantity: IntegerEditor;
}

export class CartsForm extends PrefixedContext {
    static readonly formKey = 'ECommerceWebsite.Carts';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CartsForm.init)  {
            CartsForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = IntegerEditor;

            initFormType(CartsForm, [
                'UserId', w0,
                'ProductId', w1,
                'Quantity', w2
            ]);
        }
    }
}
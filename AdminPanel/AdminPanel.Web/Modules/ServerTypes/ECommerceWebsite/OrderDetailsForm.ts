import { StringEditor, ServiceLookupEditor, IntegerEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface OrderDetailsForm {
    UserId: StringEditor;
    ProductId: ServiceLookupEditor;
    Quantity: IntegerEditor;
    OrderId: ServiceLookupEditor;
    Price: DecimalEditor;
}

export class OrderDetailsForm extends PrefixedContext {
    static readonly formKey = 'ECommerceWebsite.OrderDetails';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!OrderDetailsForm.init)  {
            OrderDetailsForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = IntegerEditor;
            var w3 = DecimalEditor;

            initFormType(OrderDetailsForm, [
                'UserId', w0,
                'ProductId', w1,
                'Quantity', w2,
                'OrderId', w1,
                'Price', w3
            ]);
        }
    }
}
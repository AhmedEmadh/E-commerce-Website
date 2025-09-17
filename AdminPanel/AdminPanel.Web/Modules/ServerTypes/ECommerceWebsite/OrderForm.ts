import { StringEditor, DateEditor, DecimalEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface OrderForm {
    Name: StringEditor;
    Address: StringEditor;
    Email: StringEditor;
    Phone: StringEditor;
    UserId: StringEditor;
    DateAdded: DateEditor;
    TotalPrice: DecimalEditor;
    Status: IntegerEditor;
}

export class OrderForm extends PrefixedContext {
    static readonly formKey = 'ECommerceWebsite.Order';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!OrderForm.init)  {
            OrderForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = DecimalEditor;
            var w3 = IntegerEditor;

            initFormType(OrderForm, [
                'Name', w0,
                'Address', w0,
                'Email', w0,
                'Phone', w0,
                'UserId', w0,
                'DateAdded', w1,
                'TotalPrice', w2,
                'Status', w3
            ]);
        }
    }
}
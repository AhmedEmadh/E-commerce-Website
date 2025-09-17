import { StringEditor, BooleanEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AspNetUsersForm {
    UserName: StringEditor;
    NormalizedUserName: StringEditor;
    Email: StringEditor;
    NormalizedEmail: StringEditor;
    EmailConfirmed: BooleanEditor;
    PasswordHash: StringEditor;
    SecurityStamp: StringEditor;
    ConcurrencyStamp: StringEditor;
    PhoneNumber: StringEditor;
    PhoneNumberConfirmed: BooleanEditor;
    TwoFactorEnabled: BooleanEditor;
    LockoutEnd: StringEditor;
    LockoutEnabled: BooleanEditor;
    AccessFailedCount: IntegerEditor;
}

export class AspNetUsersForm extends PrefixedContext {
    static readonly formKey = 'ECommerceWebsite.AspNetUsers';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AspNetUsersForm.init)  {
            AspNetUsersForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;
            var w2 = IntegerEditor;

            initFormType(AspNetUsersForm, [
                'UserName', w0,
                'NormalizedUserName', w0,
                'Email', w0,
                'NormalizedEmail', w0,
                'EmailConfirmed', w1,
                'PasswordHash', w0,
                'SecurityStamp', w0,
                'ConcurrencyStamp', w0,
                'PhoneNumber', w0,
                'PhoneNumberConfirmed', w1,
                'TwoFactorEnabled', w1,
                'LockoutEnd', w0,
                'LockoutEnabled', w1,
                'AccessFailedCount', w2
            ]);
        }
    }
}
import { fieldsProxy } from "@serenity-is/corelib";

export interface CartsRow {
    Id?: number;
    UserId?: string;
    ProductId?: number;
    Quantity?: number;
    ProductName?: string;
}

export abstract class CartsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'UserId';
    static readonly localTextPrefix = 'ECommerceWebsite.Carts';
    static readonly deletePermission = 'Carts';
    static readonly insertPermission = 'Carts';
    static readonly readPermission = 'Carts';
    static readonly updatePermission = 'Carts';

    static readonly Fields = fieldsProxy<CartsRow>();
}
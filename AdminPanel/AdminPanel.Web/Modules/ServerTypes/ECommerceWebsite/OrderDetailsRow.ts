import { fieldsProxy } from "@serenity-is/corelib";

export interface OrderDetailsRow {
    Id?: number;
    UserId?: string;
    ProductId?: number;
    Quantity?: number;
    OrderId?: number;
    Price?: number;
    UserName?: string;
    ProductName?: string;
    OrderName?: string;
}

export abstract class OrderDetailsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'UserId';
    static readonly localTextPrefix = 'ECommerceWebsite.OrderDetails';
    static readonly deletePermission = 'OrderDetails';
    static readonly insertPermission = 'OrderDetails';
    static readonly readPermission = 'OrderDetails';
    static readonly updatePermission = 'OrderDetails';

    static readonly Fields = fieldsProxy<OrderDetailsRow>();
}
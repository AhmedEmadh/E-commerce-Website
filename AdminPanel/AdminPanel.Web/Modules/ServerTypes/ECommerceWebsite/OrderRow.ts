import { fieldsProxy } from "@serenity-is/corelib";

export interface OrderRow {
    Id?: number;
    Name?: string;
    Address?: string;
    Email?: string;
    Phone?: string;
    UserId?: string;
    DateAdded?: string;
    TotalPrice?: number;
    Status?: number;
}

export abstract class OrderRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'ECommerceWebsite.Order';
    static readonly deletePermission = 'Order';
    static readonly insertPermission = 'Order';
    static readonly readPermission = 'Order';
    static readonly updatePermission = 'Order';

    static readonly Fields = fieldsProxy<OrderRow>();
}
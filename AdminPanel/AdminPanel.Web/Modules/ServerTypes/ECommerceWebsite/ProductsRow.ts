import { fieldsProxy } from "@serenity-is/corelib";

export interface ProductsRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Price?: number;
    CategoryId?: number;
    Photo?: string;
    DateAdded?: string;
    Quantity?: number;
    CategoryName?: string;
}

export abstract class ProductsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'ECommerceWebsite.Products';
    static readonly deletePermission = 'Products';
    static readonly insertPermission = 'Products';
    static readonly readPermission = 'Products';
    static readonly updatePermission = 'Products';

    static readonly Fields = fieldsProxy<ProductsRow>();
}
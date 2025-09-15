import { fieldsProxy } from "@serenity-is/corelib";

export interface CategoriesRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Photo?: string;
}

export abstract class CategoriesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'ECommerceWebsite.Categories';
    static readonly deletePermission = 'Categories';
    static readonly insertPermission = 'Categories';
    static readonly readPermission = 'Categories';
    static readonly updatePermission = 'Categories';

    static readonly Fields = fieldsProxy<CategoriesRow>();
}
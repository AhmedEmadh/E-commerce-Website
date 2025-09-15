import { fieldsProxy } from "@serenity-is/corelib";

export interface ReviewsRow {
    Id?: number;
    Name?: string;
    Email?: string;
    Subject?: string;
    Description?: string;
}

export abstract class ReviewsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'ECommerceWebsite.Reviews';
    static readonly deletePermission = 'Reviews';
    static readonly insertPermission = 'Reviews';
    static readonly readPermission = 'Reviews';
    static readonly updatePermission = 'Reviews';

    static readonly Fields = fieldsProxy<ReviewsRow>();
}
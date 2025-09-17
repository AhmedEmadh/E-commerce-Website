import { fieldsProxy } from "@serenity-is/corelib";

export interface AspNetUsersRow {
    Id?: string;
    UserName?: string;
    NormalizedUserName?: string;
    Email?: string;
    NormalizedEmail?: string;
    EmailConfirmed?: boolean;
    PasswordHash?: string;
    SecurityStamp?: string;
    ConcurrencyStamp?: string;
    PhoneNumber?: string;
    PhoneNumberConfirmed?: boolean;
    TwoFactorEnabled?: boolean;
    LockoutEnd?: string;
    LockoutEnabled?: boolean;
    AccessFailedCount?: number;
}

export abstract class AspNetUsersRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Id';
    static readonly localTextPrefix = 'ECommerceWebsite.AspNetUsers';
    static readonly deletePermission = 'AspNetUsers';
    static readonly insertPermission = 'AspNetUsers';
    static readonly readPermission = 'AspNetUsers';
    static readonly updatePermission = 'AspNetUsers';

    static readonly Fields = fieldsProxy<AspNetUsersRow>();
}
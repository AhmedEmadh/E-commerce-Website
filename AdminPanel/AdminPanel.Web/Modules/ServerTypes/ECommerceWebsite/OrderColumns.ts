import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { OrderRow } from "./OrderRow";

export interface OrderColumns {
    Id: Column<OrderRow>;
    Name: Column<OrderRow>;
    Address: Column<OrderRow>;
    Email: Column<OrderRow>;
    Phone: Column<OrderRow>;
    UserId: Column<OrderRow>;
    DateAdded: Column<OrderRow>;
    TotalPrice: Column<OrderRow>;
    Status: Column<OrderRow>;
}

export class OrderColumns extends ColumnsBase<OrderRow> {
    static readonly columnsKey = 'ECommerceWebsite.Order';
    static readonly Fields = fieldsProxy<OrderColumns>();
}
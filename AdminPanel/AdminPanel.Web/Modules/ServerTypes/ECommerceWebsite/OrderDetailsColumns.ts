import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { OrderDetailsRow } from "./OrderDetailsRow";

export interface OrderDetailsColumns {
    Id: Column<OrderDetailsRow>;
    UserName: Column<OrderDetailsRow>;
    ProductName: Column<OrderDetailsRow>;
    Quantity: Column<OrderDetailsRow>;
    OrderName: Column<OrderDetailsRow>;
    Price: Column<OrderDetailsRow>;
}

export class OrderDetailsColumns extends ColumnsBase<OrderDetailsRow> {
    static readonly columnsKey = 'ECommerceWebsite.OrderDetails';
    static readonly Fields = fieldsProxy<OrderDetailsColumns>();
}
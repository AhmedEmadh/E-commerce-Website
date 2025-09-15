import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CartsRow } from "./CartsRow";

export interface CartsColumns {
    Id: Column<CartsRow>;
    UserId: Column<CartsRow>;
    ProductName: Column<CartsRow>;
    Quantity: Column<CartsRow>;
}

export class CartsColumns extends ColumnsBase<CartsRow> {
    static readonly columnsKey = 'ECommerceWebsite.Carts';
    static readonly Fields = fieldsProxy<CartsColumns>();
}
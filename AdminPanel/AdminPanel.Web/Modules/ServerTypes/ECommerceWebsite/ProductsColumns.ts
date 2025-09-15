import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ProductsRow } from "./ProductsRow";

export interface ProductsColumns {
    Id: Column<ProductsRow>;
    Name: Column<ProductsRow>;
    Description: Column<ProductsRow>;
    Price: Column<ProductsRow>;
    CategoryName: Column<ProductsRow>;
    Photo: Column<ProductsRow>;
    DateAdded: Column<ProductsRow>;
    Quantity: Column<ProductsRow>;
}

export class ProductsColumns extends ColumnsBase<ProductsRow> {
    static readonly columnsKey = 'ECommerceWebsite.Products';
    static readonly Fields = fieldsProxy<ProductsColumns>();
}
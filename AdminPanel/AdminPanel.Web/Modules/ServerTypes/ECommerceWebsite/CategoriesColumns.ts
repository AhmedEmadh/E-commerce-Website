import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CategoriesRow } from "./CategoriesRow";

export interface CategoriesColumns {
    Id: Column<CategoriesRow>;
    Name: Column<CategoriesRow>;
    Description: Column<CategoriesRow>;
    Photo: Column<CategoriesRow>;
}

export class CategoriesColumns extends ColumnsBase<CategoriesRow> {
    static readonly columnsKey = 'ECommerceWebsite.Categories';
    static readonly Fields = fieldsProxy<CategoriesColumns>();
}
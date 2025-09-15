import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ReviewsRow } from "./ReviewsRow";

export interface ReviewsColumns {
    Id: Column<ReviewsRow>;
    Name: Column<ReviewsRow>;
    Email: Column<ReviewsRow>;
    Subject: Column<ReviewsRow>;
    Description: Column<ReviewsRow>;
}

export class ReviewsColumns extends ColumnsBase<ReviewsRow> {
    static readonly columnsKey = 'ECommerceWebsite.Reviews';
    static readonly Fields = fieldsProxy<ReviewsColumns>();
}
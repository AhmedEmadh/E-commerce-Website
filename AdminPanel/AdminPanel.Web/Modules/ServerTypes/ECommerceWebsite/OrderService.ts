import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { OrderRow } from "./OrderRow";

export namespace OrderService {
    export const baseUrl = 'ECommerceWebsite/Order';

    export declare function Create(request: SaveRequest<OrderRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<OrderRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<OrderRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<OrderRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<OrderRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<OrderRow>>;

    export const Methods = {
        Create: "ECommerceWebsite/Order/Create",
        Update: "ECommerceWebsite/Order/Update",
        Delete: "ECommerceWebsite/Order/Delete",
        Retrieve: "ECommerceWebsite/Order/Retrieve",
        List: "ECommerceWebsite/Order/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>OrderService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
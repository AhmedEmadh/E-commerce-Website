import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { CartsRow } from "./CartsRow";

export namespace CartsService {
    export const baseUrl = 'ECommerceWebsite/Carts';

    export declare function Create(request: SaveRequest<CartsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CartsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CartsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CartsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CartsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CartsRow>>;

    export const Methods = {
        Create: "ECommerceWebsite/Carts/Create",
        Update: "ECommerceWebsite/Carts/Update",
        Delete: "ECommerceWebsite/Carts/Delete",
        Retrieve: "ECommerceWebsite/Carts/Retrieve",
        List: "ECommerceWebsite/Carts/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CartsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
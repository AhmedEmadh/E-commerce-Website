import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ReviewsRow } from "./ReviewsRow";

export namespace ReviewsService {
    export const baseUrl = 'ECommerceWebsite/Reviews';

    export declare function Create(request: SaveRequest<ReviewsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ReviewsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ReviewsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ReviewsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ReviewsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ReviewsRow>>;

    export const Methods = {
        Create: "ECommerceWebsite/Reviews/Create",
        Update: "ECommerceWebsite/Reviews/Update",
        Delete: "ECommerceWebsite/Reviews/Delete",
        Retrieve: "ECommerceWebsite/Reviews/Retrieve",
        List: "ECommerceWebsite/Reviews/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ReviewsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
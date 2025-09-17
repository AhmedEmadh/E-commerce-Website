import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AspNetUsersRow } from "./AspNetUsersRow";

export namespace AspNetUsersService {
    export const baseUrl = 'ECommerceWebsite/AspNetUsers';

    export declare function Create(request: SaveRequest<AspNetUsersRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AspNetUsersRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AspNetUsersRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AspNetUsersRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AspNetUsersRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AspNetUsersRow>>;

    export const Methods = {
        Create: "ECommerceWebsite/AspNetUsers/Create",
        Update: "ECommerceWebsite/AspNetUsers/Update",
        Delete: "ECommerceWebsite/AspNetUsers/Delete",
        Retrieve: "ECommerceWebsite/AspNetUsers/Retrieve",
        List: "ECommerceWebsite/AspNetUsers/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AspNetUsersService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
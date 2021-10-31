using System.Threading.Tasks;
using DotNetService.Models;
using Refit;

namespace DotNetService.Data
{
    public interface IProductRepository
    {
        // We are using refit so the request method, relative url, custom headers and parameters are set through these attributes
        [Headers("Cookie: VtexIdclientAutCookie=eyJhbGciOiJFUzI1NiIsImtpZCI6IjhCMjY5MjAwRUZDNkZEM0UwRjRFRDU2MTE2RTlFOTYwQTAzQ0Y5OEEiLCJ0eXAiOiJqd3QifQ.eyJzdWIiOiJ2dGV4YXBwa2V5LWRlY29yZXN0LVZJV0FEViIsImFjY291bnQiOiJ2dGV4IiwiYXVkaWVuY2UiOiJhZG1pbiIsImV4cCI6MTYzNTY4MDkzMywidXNlcklkIjoiNDI0MmY3ZmUtNjFkOC00MzY2LThiZDAtZGI1YWNmMzk5YTZmIiwiaWF0IjoxNjM1NjU5MzMzLCJpc3MiOiJ0b2tlbi1lbWl0dGVyIiwianRpIjoiOWIxNTE0YzYtYjRlNi00NDdhLWE1NDAtMjAyMzgxZTY4OGYzIn0.7UMphYVT0ocaR2nO_Q7NXZ2W4fLWKtgZQtk2ylfoeWENeyvydmZ3KJGVx_f2Pzr-rEiHeidy-JIfXj5QXVSxEQ")]
        [Post("/Export/GenerateExport?selectedFields=clientName,clientRut,companyRut,creationDate,giftcardAmount,giftcardDeliveryType,giftcardQuantity,giftcardRestriction,giftcardTaxes,orderNumber&idDataEntity=GD&fullText=&searchQuery=orderNumber%3D100000000&recipients=jorge.espinosa@vtex.com.br")]
        Task<Product> GetProduct(int productId);
    }
}
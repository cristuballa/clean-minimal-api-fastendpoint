namespace MinimalApi.Endpoints;

[HttpDelete("deletecustomer"), AllowAnonymous]
public class DeleteCustomerEndpoint:Endpoint<DeleteCustomerRequest>
{
    public override async Task HandleAsync(DeleteCustomerRequest request, CancellationToken ct)
    {
        await SendNoContentAsync(ct);
    }
}
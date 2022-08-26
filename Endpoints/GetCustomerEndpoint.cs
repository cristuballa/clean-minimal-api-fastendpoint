
namespace MinimalApi.Endpoints;

public class GetCustomerEndpoint:Endpoint<GetCustomerRequest, CustomerResponse>
{
    public override async Task HandleAsync(GetCustomerRequest request, CancellationToken ct)
    {
        var customerResponse= new CustomerResponse{
            Name="Customer Name",
            Balance=0

        };
        await SendAsync(customerResponse, cancellation: ct);
    }
}

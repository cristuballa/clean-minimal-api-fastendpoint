namespace MinimalApi.Endpoints;
[HttpPost("createcustomer"),]
public class CreateCustomerEndpoint:Endpoint<CustomerRequest,CustomerResponse>
{
    public override async Task HandleAsync(CustomerRequest request, CancellationToken ct)
    {
       var response=new CustomerResponse
       {
        Id=new Guid(),
        Name="Customer Name",
        Balance=100,
       };
       await SendCreatedAtAsync<GetAllCustomersEndpoint>(new{Id=response.Id},response,generateAbsoluteUrl:true,cancellation:ct);
    }
}
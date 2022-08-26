namespace MinimalApi.Endpoints;
[HttpGet("GetAllCustomer"),AllowAnonymous]
public class GetAllCustomersEndpoint:EndpointWithoutRequest<CustomerResponse>
{
   public override async Task HandleAsync(CancellationToken ct)
   {
    var responseNew=new CustomerResponse
    {
        Id=new Guid(),
        Name="Customer Name", 
        Balance=67
    };
    await SendAsync(responseNew);
   }
}



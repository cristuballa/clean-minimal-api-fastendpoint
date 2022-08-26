[HttpPut("updatecustomer"), AllowAnonymous]
public class UpdateCustomerEndpoint:Endpoint<UpdateCustomerRequest, CustomerResponse>
{
    public override async Task HandleAsync(UpdateCustomerRequest request,CancellationToken ct)
    {
        var customerResponse=new CustomerResponse
        {
            Id= new Guid(),
            Name="Customer Response",
            Balance=0           
        };
        await SendOkAsync(customerResponse,ct);
    }
}
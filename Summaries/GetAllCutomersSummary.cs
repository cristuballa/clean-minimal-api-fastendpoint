
namespace MinimalApi.Summary;
public class GetAllCustomersSummary:Summary<GetAllCustomersEndpoint>
{
    public GetAllCustomersSummary()
    {
        Summary="Summary";
        Description="Description";
        Response<GetAllCustomerResponse>(200,"Successfull");
    }
}
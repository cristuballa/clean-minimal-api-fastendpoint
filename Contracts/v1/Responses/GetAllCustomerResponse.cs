public class GetAllCustomerResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; }=default!;
    public float Balance  { get; init; }
}
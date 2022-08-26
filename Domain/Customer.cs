
using Minimalapi.Domain.Common;

public class Customer
{
    public  CustomerId Id  { get; init; } = CustomerId.From(Guid.NewGuid());
    public string Name {get;init;}=default!;
    public int Balance { get; init; }
}
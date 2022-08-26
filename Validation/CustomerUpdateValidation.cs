public class UpdateCustomerValidator:AbstractValidator<UpdateCustomerRequest>
{
    public UpdateCustomerValidator()
    {
        RuleFor(x=>x.Name).NotEmpty();
        RuleFor(x=>x.Balance).GreaterThan(0);
    }
}
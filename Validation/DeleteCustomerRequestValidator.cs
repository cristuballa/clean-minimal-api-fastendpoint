public class DeleteCustomerRequestValidator:AbstractValidator<DeleteCustomerRequest>
{
    public DeleteCustomerRequestValidator()
    {
        RuleFor(x=>x.Id).NotEmpty();
    }
}
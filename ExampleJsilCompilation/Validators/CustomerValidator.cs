using ExampleJsilCompilation.Classes;
using FluentValidation;

namespace ExampleJsilCompilation.Validators
{
    class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.FirstName).NotNull().NotEmpty();
            RuleFor(customer => customer.LastName).NotNull().NotEmpty();
            RuleFor(customer => customer.Id).GreaterThan(0);
        }
    }
}

using FluentValidation;

namespace MovieSolvex.API.Models
{
    public class UsersValidator : AbstractValidator<Users>
    {
        public UsersValidator()
        {

            RuleFor(u => u.Name).NotNull().NotEmpty();
            RuleFor(u => u.Password).NotNull().NotEmpty().MaximumLength(10).MinimumLength(3);

        }

    }
}

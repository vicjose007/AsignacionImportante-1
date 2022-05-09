using FluentValidation;
using MovieSolvex.Domain;

namespace MovieSolvex.API.Models
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(m => m.Id).NotNull().NotEmpty();
            RuleFor(m => m.Name).NotNull().NotEmpty().MaximumLength(20).MinimumLength(3);
            RuleFor(m => m.Price).NotNull().NotEmpty();
            RuleFor(m => m.DateTime).NotNull().NotEmpty();
            RuleFor(m => m.Director).NotNull().NotEmpty().MaximumLength(50).MinimumLength(3);
            RuleFor(m => m.Local).NotNull().NotEmpty().MaximumLength(50).MinimumLength(3);
            RuleFor(m => m.ActorsNumber).NotNull().NotEmpty();
            RuleFor(m => m.MusicDirector).NotNull().NotEmpty().MaximumLength(50).MinimumLength(3);
            RuleFor(m => m.CostumDesigner).NotNull().NotEmpty().MaximumLength(50).MinimumLength(3);
            RuleFor(m => m.Duration).NotNull().NotEmpty();
        }

    }
}

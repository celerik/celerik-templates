using FluentValidation;
using {{namespace}}.Model;

namespace {{namespace}}.Services
{
    public class Get{{main-entity}}Validator : AbstractValidator<Get{{main-entity}}Payload>
    {
        public Get{{main-entity}}Validator()
        {
            RuleFor(payload => payload.{{main-entity}}Id)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50);
        }
    }
}

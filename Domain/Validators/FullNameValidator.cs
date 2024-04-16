using Domen.Primitivies;
using Domen.ValueObject;
using FluentValidation;

namespace Domen.Validators;

public class FullNameValidator : AbstractValidator<FullName>
{
    public FullNameValidator()
    {
        RuleFor(x => x.FirstName).Matches(@"^[a-zA-Zа-яА-Я]+$")
            .NotNull().WithMessage(x => ValidationMessages.NotNull(nameof(x)))
            .NotEmpty().WithMessage(x => ValidationMessages.NotEmpty(nameof(x)));

        RuleFor (x => x.LastName).Matches(@"^[a-zA-Zа-яА-Я]+$")
            .NotNull().WithMessage(x => ValidationMessages.NotNull(nameof(x)))
            .NotEmpty().WithMessage(x => ValidationMessages.NotEmpty(nameof(x)));


        RuleFor(x => x.MiddleName)
            .NotNull().WithMessage(x => ValidationMessages.NotNull(nameof(x)))
            .NotEmpty().WithMessage(x => ValidationMessages.NotEmpty(nameof(x)))
            .Must(ValidationMiddleName).WithMessage(x => ValidationMessages.OverFlow(nameof(x)));
    }
    private static bool ValidationMiddleName(string middleName)
    {
        if (middleName.Length == 0)
            return true;
        return middleName.Length <= 20;
    }
}
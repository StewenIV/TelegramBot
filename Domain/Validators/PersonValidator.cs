using Domen.Entity;
using Domen.Primitivies;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Domen.Validators;

public class PersonValidator : AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(x => x.PhoneNumber).Matches(@"^\+37377[4-9]\d{5}$")
            .WithMessage(x => ValidationMessages.InvalidProperty(nameof(x)))
            .NotEmpty().WithMessage(x => ValidationMessages.NotEmpty(nameof(x)))
            .NotNull().WithMessage(x => ValidationMessages.NotNull(nameof(x)));

        RuleFor(x => x.BirthDay)
            .Must(BirthDayValidation).WithMessage(x => ValidationMessages.InvalidBirthday(nameof(x)))
            .NotEmpty().WithMessage(x => ValidationMessages.NotEmpty(nameof(x)))
            .NotNull().WithMessage(x => ValidationMessages.NotNull(nameof(x)));

        RuleFor(x => x.Telegram).Matches(@"^@[a-zA-Z0-9]{3,19}$")
            .WithMessage(x => ValidationMessages.TelegramValidation(nameof(x)))
            .NotEmpty().WithMessage(x => ValidationMessages.NotEmpty(nameof(x)))
            .NotNull().WithMessage(x => ValidationMessages.NotNull(nameof(x)));
    }
    private static bool BirthDayValidation(DateTime birthDay)
    {
        if (birthDay.Millisecond != 0 && birthDay <= DateTime.Today)
            return true;
        return false;
    }
}
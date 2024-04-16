using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen.Validators;
using FluentValidation.Internal;

namespace Domen.ValueObject
{
    public class FullName : BaseValueObject
    {
        public FullName(string firstName, string lastName, string middleName)
        {
            var validator = new FullNameValidator();
            validator.Validate(this);
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string MiddleName { get; set; } = string.Empty;
    }
}
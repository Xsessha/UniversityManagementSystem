using FluentValidation;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Core.Validators;

public class StudentValidator
    : AbstractValidator<Student>
{
    public StudentValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.LastName)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.Email)
            .EmailAddress();

        RuleFor(x => x.Rating)
            .InclusiveBetween(0, 100);
    }
}
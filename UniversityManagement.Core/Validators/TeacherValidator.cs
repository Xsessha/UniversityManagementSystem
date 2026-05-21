using FluentValidation;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Core.Validators;

public class TeacherValidator
    : AbstractValidator<Teacher>
{
    public TeacherValidator()
    {
        RuleFor(x => x.FullName)
            .NotEmpty();

        RuleFor(x => x.Department)
            .NotEmpty();

        RuleFor(x => x.Email)
            .EmailAddress();
    }
}
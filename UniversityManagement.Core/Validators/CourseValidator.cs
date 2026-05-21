using FluentValidation;
using UniversityManagement.Core.Models;

namespace UniversityManagement.Core.Validators;

public class CourseValidator
    : AbstractValidator<Course>
{
    public CourseValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty();

        RuleFor(x => x.Credits)
            .InclusiveBetween(1, 20);
    }
}
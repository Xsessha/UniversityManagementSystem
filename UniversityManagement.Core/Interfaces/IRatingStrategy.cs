using UniversityManagement.Core.Models;

namespace UniversityManagement.Core.Interfaces;

public interface IRatingStrategy
{
    double CalculateRating(Student student);
}

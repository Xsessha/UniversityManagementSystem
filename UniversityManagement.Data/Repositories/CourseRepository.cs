using Microsoft.EntityFrameworkCore;
using UniversityManagement.Core.Models;
using UniversityManagement.Data.Context;

namespace UniversityManagement.Data.Repositories;

public class CourseRepository
    : GenericRepository<Course>
{
    public CourseRepository(
        UniversityDbContext context)
        : base(context)
    {
    }

    public override async Task<List<Course>> GetAllAsync()
    {
        return await _context.Courses
            .Include(x => x.Teacher)
            .Include(x => x.Students)
            .ToListAsync();
    }
}
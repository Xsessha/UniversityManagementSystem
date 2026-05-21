using Microsoft.EntityFrameworkCore;
using UniversityManagement.Core.Models;
using UniversityManagement.Data.Context;

namespace UniversityManagement.Data.Repositories;

public class StudentRepository
    : GenericRepository<Student>
{
    public StudentRepository(
        UniversityDbContext context)
        : base(context)
    {
    }

    public override async Task<List<Student>> GetAllAsync()
    {
        return await _context.Students
            .Include(x => x.Group)
            .Include(x => x.Grades)
            .ToListAsync();
    }
}
using Microsoft.EntityFrameworkCore;
using UniversityManagement.Core.Models;
using UniversityManagement.Data.Context;

namespace UniversityManagement.Data.Repositories;

public class TeacherRepository
    : GenericRepository<Teacher>
{
    public TeacherRepository(
        UniversityDbContext context)
        : base(context)
    {
    }

    public override async Task<List<Teacher>> GetAllAsync()
    {
        return await _context.Teachers
            .Include(x => x.Courses)
            .ToListAsync();
    }
}
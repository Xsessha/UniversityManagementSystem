using Microsoft.EntityFrameworkCore;
using UniversityManagement.Core.Models;
using UniversityManagement.Data.Context;

namespace UniversityManagement.Data.Repositories;

public class FacultyRepository
    : GenericRepository<Faculty>
{
    public FacultyRepository(
        UniversityDbContext context)
        : base(context)
    {
    }

    public override async Task<List<Faculty>> GetAllAsync()
    {
        return await _context.Faculties
            .Include(x => x.Groups)
            .ThenInclude(g => g.Students)
            .ToListAsync();
    }
}
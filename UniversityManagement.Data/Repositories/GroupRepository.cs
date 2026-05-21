using Microsoft.EntityFrameworkCore;
using UniversityManagement.Core.Models;
using UniversityManagement.Data.Context;

namespace UniversityManagement.Data.Repositories;

public class GroupRepository
    : GenericRepository<Group>
{
    public GroupRepository(
        UniversityDbContext context)
        : base(context)
    {
    }

    public override async Task<List<Group>> GetAllAsync()
    {
        return await _context.Groups
            .Include(x => x.Faculty)
            .Include(x => x.Students)
            .ToListAsync();
    }
}
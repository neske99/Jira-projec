using Microsoft.EntityFrameworkCore;
using Project.Application.Contracts;
using Project.Infrastructure.Persistence;

namespace Project.Infrastructure.Repositories;
public class ProductRepository : IProjectRepository
{
  private readonly ProjectContext _context;

  public ProductRepository(ProjectContext context)
  {
    _context = context ?? throw new ArgumentNullException(nameof(context));
  }

  public Task<List<Project.Domain.Entities.Project.Project>> GetAllProjectsForUserAsync(int userId)
  {
    var projects = from pt in _context.ProjectTeams
                   join p in _context.Projects on pt.ProjectId equals p.Id
                   join ut in _context.UserTeams on pt.TeamsId equals ut.TeamId
                   where ut.UserId == userId && !pt.IsDeleted && !p.IsDeleted && !ut.IsDeleted
                   select p;

    return projects.Include(p=>p.ProjectStatus).Include(p=>p.ProjectType).ToListAsync();
  }
}
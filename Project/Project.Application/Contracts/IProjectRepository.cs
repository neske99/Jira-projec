
namespace Project.Application.Contracts;
public interface IProjectRepository
{
  public Task<List<Project.Domain.Entities.Project.Project>> GetAllProjectsForUserAsync(int userId);

}
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Project;
using Project.Domain.Entities.Task;
using Project.Domain.Entities.User;
namespace Project.Infrastructure.Persistence;

public class ProjectContext:DbContext
{
  public ProjectContext(DbContextOptions options) : base(options)
  {
  }

  #region Project

  public DbSet<Project.Domain.Entities.Project.Project> Projects{ get; set; }
  public DbSet<ProjectAction> ProjectActions{ get; set; }
  public DbSet<ProjectActoinRole> ProjectActionRoles{ get; set; }
  public DbSet<ProjectStatus> ProjectStatuses{ get; set; }
  public DbSet<ProjectType> ProjectTypes{ get; set; }
  public DbSet<ProjectTeam> ProjectTeams{ get; set; }

  #endregion

  #region Task
  public DbSet<Project.Domain.Entities.Task.Task> Tasks{ get; set; }
  public DbSet<TaskAction> TaskActions{ get; set; }
  public DbSet<Project.Domain.Entities.Task.TaskStatus> TaskStatuse{ get; set; }
  public DbSet<TaskType> TaskTypes{ get; set; }
  public DbSet<TaskActionRole> TaskActionRoles { get; set; }

  #endregion


  #region User
  public DbSet<User> Users{ get; set; }
  public DbSet<Role> Roles{ get; set; }
  public DbSet<Team> Teams{ get; set; }
  public DbSet<UserTeam> UserTeams{ get; set; }
  public DbSet<UserRole> UserRole{ get; set; }

  #endregion
}
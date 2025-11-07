using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities.Project;
using Project.Domain.Entities.Task;

public class ProjectContext:DbContext
{

  #region Project

  DbSet<Project.Domain.Entities.Project.Project> Projects{ get; set; }
  DbSet<ProjectAction> ProjectActions{ get; set; }
  DbSet<ProjectActoinRole> ProjectActionRoles{ get; set; }
  DbSet<ProjectStatus> ProjectStatuses{ get; set; }
  DbSet<ProjectType> ProjectTypes{ get; set; }

  #endregion

  #region Task
  DbSet<Project.Domain.Entities.Task.Task> Tasks{ get; set; }
  DbSet<TaskAction> TaskActions{ get; set; }
  DbSet<Project.Domain.Entities.Task.TaskStatus> TaskStatuse{ get; set; }
  DbSet<TaskType> TaskTypes{ get; set; }
  DbSet<TaskActionRole> TaskActionRoles { get; set; }

  #endregion


  #region User
  DbSet<User> Users{ get; set; }
  DbSet<Role> Roles{ get; set; }
  DbSet<Team> Teams{ get; set; }
  DbSet<UserTeam> UserTeams{ get; set; }
  DbSet<UserRole> UserRole{ get; set; }

  #endregion
}

using Project.Domain.Entities.Common;
namespace Project.Domain.Entities.Project;

public class ProjectTeam: EnttitySoftDelete
{
  public int ProjectId { get; set; }
  public int TeamsId { get; set; }

}
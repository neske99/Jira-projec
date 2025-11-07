using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.Project;
public class ProjectAction:EnttitySoftDelete
{
  public string ProjectActionName { get; set; } = string.Empty;
  public int ProjectStatusIdFrom{ get; set; }
  public int ProjectStatusIdTo{ get; set; }
  public int ProjectTypeId{ get; set; }
  public int RoleId{ get; set; }

}
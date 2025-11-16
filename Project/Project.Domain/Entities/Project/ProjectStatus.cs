using Project.Domain.Entities.Common;
namespace Project.Domain.Entities.Project;

public class ProjectStatus:EnttitySoftDelete
{
  public int ProjecTypeId { get; set; }
  public string StatusName { get; set; }=string.Empty;
}
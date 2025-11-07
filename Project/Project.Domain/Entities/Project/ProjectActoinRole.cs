using Project.Domain.Entities.Common;
namespace Project.Domain.Entities.Project;

public class ProjectActoinRole:EnttitySoftDelete
{
    public int ProjectActionId { get; set; }
    public int RoleId { get; set; }

}
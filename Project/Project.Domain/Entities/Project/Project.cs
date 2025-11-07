using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.Project;
public class Project:EnttitySoftDelete
{
    public string Name { get; set; }= string.Empty;
    public string Description { get; set; } = string.Empty;
    public int ProjectTypeId { get; set; }
    public int ProjectStatusId { get; set; }
}
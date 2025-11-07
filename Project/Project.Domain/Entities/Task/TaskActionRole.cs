using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.Task;
public class TaskActionRole:EnttitySoftDelete
{
    public int TaskActionId { get; set; }
    public int RoleId { get; set; }
}
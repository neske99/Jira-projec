using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.Task;
public class TaskStatus: EnttitySoftDelete
{
    public string StatusName { get; set; } = string.Empty;
    public int TaskTypeId { get; set; }

}
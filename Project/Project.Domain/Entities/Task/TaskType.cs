using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.Task;
public class TaskType:EnttitySoftDelete
{
  public string TaskTypeName { get; set; }=string.Empty;

}
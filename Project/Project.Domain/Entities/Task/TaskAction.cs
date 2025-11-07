using Project.Domain.Entities.Common;

public class TaskAction: EnttitySoftDelete
{
  public string TaskActionName { get; set; }=string.Empty;
  public int RoleId{ get; set; }
  public int TaskStatusIdFrom{ get; set; }
  public int TaskStatusIdTo{ get; set; }
  public int TaskTypeId{ get; set; }
}
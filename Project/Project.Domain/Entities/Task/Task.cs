using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.Task;
public class Task:EnttitySoftDelete
{
    public int? ProjectId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;

}
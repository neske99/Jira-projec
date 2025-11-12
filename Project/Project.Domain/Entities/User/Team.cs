using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.User;
public class Team: EnttitySoftDelete
{
  public string TeamName { get; set; } = string.Empty;


}
using Project.Domain.Entities.Common;

public class UserTeam: EnttitySoftDelete
{
    public int UserId { get; set; }
    public int TeamId { get; set; }

}
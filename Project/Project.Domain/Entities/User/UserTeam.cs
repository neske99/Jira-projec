using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.User;
public class UserTeam: EnttitySoftDelete
{
    public int UserId { get; set; }
    public int TeamId { get; set; }

}
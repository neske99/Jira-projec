using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.User;
public class UserRole:EnttitySoftDelete
{
    public int UserId { get; set; }
    public int RoleId { get; set; }


}
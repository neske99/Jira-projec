using Project.Domain.Entities.Common;

public class UserRole:EnttitySoftDelete
{
    public int UserId { get; set; }
    public int RoleId { get; set; }


}
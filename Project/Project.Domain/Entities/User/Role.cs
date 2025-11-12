using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.User;
public class Role:EnttitySoftDelete
{
    public string RoleName { get; set; } = string.Empty;

}
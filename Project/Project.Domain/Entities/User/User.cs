using Project.Domain.Entities.Common;

namespace Project.Domain.Entities.User;
public class User:EnttitySoftDelete
{
    public string Username { get; set; } = string.Empty;
}
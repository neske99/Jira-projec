using Project.Domain.Entities.Common;

public class User:EnttitySoftDelete
{
    public string Username { get; set; } = string.Empty;
}
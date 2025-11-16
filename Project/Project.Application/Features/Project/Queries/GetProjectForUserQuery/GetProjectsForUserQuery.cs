using MediatR;

public class GetProjectsForUserQuery: IRequest<List<Project.Domain.Entities.Project.Project>>
{
  public int UserId { get; set; }

}
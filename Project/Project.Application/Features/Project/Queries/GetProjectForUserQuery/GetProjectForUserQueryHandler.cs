using MediatR;
using Project.Application.Contracts;

public class GetProjectForUserQueryHandler : IRequestHandler<GetProjectsForUserQuery, List<Project.Domain.Entities.Project.Project>>
{
  private readonly IProjectRepository _projectRepository;

  public GetProjectForUserQueryHandler(IProjectRepository projectRepository)
  {
    _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
  }

  public Task<List<Project.Domain.Entities.Project.Project>> Handle(GetProjectsForUserQuery request, CancellationToken cancellationToken)
  {
    return _projectRepository.GetAllProjectsForUserAsync(request.UserId);
  }
}
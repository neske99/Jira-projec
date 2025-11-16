using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Project.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectController : ControllerBase
{

    private readonly IMediator _mediator;

  public ProjectController(IMediator mediator)
  {
    _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
  }

  [HttpGet("projects")]
    public async Task<IActionResult> GetProjects(int userid)
    {
      return Ok(await _mediator.Send(new GetProjectsForUserQuery { UserId = userid }));
    }

}

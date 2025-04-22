using MediatR;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using EclipseWorks.DeveloperEvaluation.WebApi.Common;
using EclipseWorks.DeveloperEvaluation.Application.Projects.ListProject;
using EclipseWorks.DeveloperEvaluation.Application.Projects.CreateProject;
using EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.ListProject;
using EclipseWorks.DeveloperEvaluation.Application.Projects.ModifiedProject;
using EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.CreateProject;
using EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects.ModifiedProject;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects;

/// <summary>
/// Controller for managing project operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ProjectsController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of ProjectsController
    /// </summary>
    /// <param name="mediator">The mediator instance</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public ProjectsController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    /// <summary>
    /// Creates a new project
    /// </summary>
    /// <param name="request">The project creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created project details</returns>
    [HttpPost("CreateProject")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetProjectResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateProject([FromBody] CreateProjectRequest request, CancellationToken cancellationToken)
    {
        var validator = new CreateProjectRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<CreateProjectCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<GetProjectResponse>
        {
            Success = true,
            Message = "Projeto criado com sucesso!",
            Data = _mapper.Map<GetProjectResponse>(response)
        });
    }

    /// <summary>
    /// Modified a project
    /// </summary>
    /// <param name="request">The project Modified request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The Modified project details</returns>
    [HttpPut("ModifiedProject")]
    [ProducesResponseType(typeof(ApiResponseWithData<ModifiedProjectResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> ModifiedSale([FromBody] ModifiedProjectRequest request, CancellationToken cancellationToken)
    {
        var validator = new ModifiedProjectRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<ModifiedProjectCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<ModifiedProjectResponse>
        {
            Success = true,
            Message = "Projeto alterado com sucesso!",
            Data = _mapper.Map<ModifiedProjectResponse>(response)
        });
    }

    /// <summary>
    /// Retrieves a project by their IDUser
    /// </summary>
    /// <param name="id">The unique identifier of the user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user details if found</returns>
    [HttpGet("ProjectByIdUser/{idUser}")]
    [ProducesResponseType(typeof(ApiResponseWithData<ListProjectResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ListProjectByIdUser([FromRoute] Guid idUser, CancellationToken cancellationToken)
    {
        var request = new ListProjectRequest { IdUser = idUser };
        
        var command = _mapper.Map<ListProjectCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<List<ListProjectResponse>>
        {
            Success = true,
            Message = "Projeto(s) do usuário("+ idUser + ") recuperado(s) com sucesso!",
            Data = _mapper.Map<List<ListProjectResponse>>(response)
        });
    }

}

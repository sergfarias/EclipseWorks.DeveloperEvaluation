using MediatR;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using EclipseWorks.DeveloperEvaluation.WebApi.Common;
using EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.UpdateTask;
using EclipseWorks.DeveloperEvaluation.Application.Tasks.UpdateTask;
using EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.CreateTask;
using EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.ListTask;
using EclipseWorks.DeveloperEvaluation.Application.Tasks.ListTask;
using EclipseWorks.DeveloperEvaluation.Application.Tasks.CreateTask;

namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects;

/// <summary>
/// Controller for managing task operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class TasksController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of TasksController
    /// </summary>
    /// <param name="mediator">The mediator instance</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public TasksController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    /// <summary>
    /// Creates a new task
    /// </summary>
    /// <param name="request">The task creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created task details</returns>
    [HttpPost("CreateTask")]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateTaskResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateTask([FromBody] CreateTaskRequest request, CancellationToken cancellationToken)
    {
        var validator = new CreateTaskRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<CreateTaskCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CreateTaskResponse>
        {
            Success = true,
            Message = "Tarefa criada com sucesso!",
            Data = _mapper.Map<CreateTaskResponse>(response)
        });
    }

    /// <summary>
    /// Update a task
    /// </summary>
    /// <param name="request">The task Update request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The Update task details</returns>
    [HttpPut("UpdateTask")]
    [ProducesResponseType(typeof(ApiResponseWithData<UpdateTaskResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateTask([FromBody] UpdateTaskRequest request, CancellationToken cancellationToken)
    {
        var validator = new UpdateTaskRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<UpdateTaskCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<UpdateTaskResponse>
        {
            Success = true,
            Message = "Tarefa alterada com sucesso!",
            Data = _mapper.Map<UpdateTaskResponse>(response)
        });
    }

    /// <summary>
    /// Retrieves a task by their IdProject
    /// </summary>
    /// <param name="id">The unique identifier of the project</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The task details if found</returns>
    [HttpGet("TaskByIdProject/{idProject}")]
    [ProducesResponseType(typeof(ApiResponseWithData<ListTaskResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ListTaskByIdProject([FromRoute] Guid idProject, CancellationToken cancellationToken)
    {
        var request = new ListTaskRequest { IdProject = idProject };
        //var validator = new ListProjectRequestValidator();
        //var validationResult = await validator.ValidateAsync(request, cancellationToken);
        //if (!validationResult.IsValid)
        //    return BadRequest(validationResult.Errors);

        var command = _mapper.Map<ListTaskCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<List<ListTaskResponse>>
        {
            Success = true,
            Message = "Task by IdProject retrieved successfully",
            Data = _mapper.Map<List<ListTaskResponse>>(response)
        });
    }

}

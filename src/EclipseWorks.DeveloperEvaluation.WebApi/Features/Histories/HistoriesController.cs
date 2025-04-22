using MediatR;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using EclipseWorks.DeveloperEvaluation.WebApi.Common;
using EclipseWorks.DeveloperEvaluation.WebApi.Features.Histories.CreateHistory;
using EclipseWorks.DeveloperEvaluation.Application.Histories.CreateHistory;
using EclipseWorks.DeveloperEvaluation.WebApi.Features.Histories.ListHistory;
using EclipseWorks.DeveloperEvaluation.Application.Histories.ListHistory;

namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Projects;

/// <summary>
/// Controller for managing task operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class HistoriesController : BaseController
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of TasksController
    /// </summary>
    /// <param name="mediator">The mediator instance</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public HistoriesController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    /// <summary>
    /// Creates a new task
    /// </summary>
    /// <param name="request">The task creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created History details</returns>
    [HttpPost("CreateHistory")]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateHistoryResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateHistory([FromBody] CreateHistoryRequest request, CancellationToken cancellationToken)
    {
        var validator = new CreateHistoryRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<CreateHistoryCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CreateHistoryResponse>
        {
            Success = true,
            Message = "History created successfully",
            Data = _mapper.Map<CreateHistoryResponse>(response)
        });
    }


    /// <summary>
    /// Retrieves a task by their IdProject
    /// </summary>
    /// <param name="id">The unique identifier of the project</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The task details if found</returns>
    [HttpGet("HistoryByIdTask/{idTask}")]
    [ProducesResponseType(typeof(ApiResponseWithData<ListHistoryResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ListHistoryByIdTask([FromRoute] Guid idTask, CancellationToken cancellationToken)
    {
        var request = new ListHistoryRequest { IdTask = idTask };
        //var validator = new ListProjectRequestValidator();
        //var validationResult = await validator.ValidateAsync(request, cancellationToken);
        //if (!validationResult.IsValid)
        //    return BadRequest(validationResult.Errors);

        var command = _mapper.Map<ListHistoryCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<List<ListHistoryResponse>>
        {
            Success = true,
            Message = "History by IdTask retrieved successfully",
            Data = _mapper.Map<List<ListHistoryResponse>>(response)
        });
    }

}

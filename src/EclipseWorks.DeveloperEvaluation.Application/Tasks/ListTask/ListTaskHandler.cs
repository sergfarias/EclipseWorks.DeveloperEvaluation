using AutoMapper;
using MediatR;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;

namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.ListTask;

/// <summary>
/// Handler for processing GetTaskCommand requests
/// </summary>
public class ListTaskHandler: IRequestHandler<ListTaskCommand, List<ListTaskResult>>
{
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of GetTaskHandler
    /// </summary>
    public ListTaskHandler(ITaskRepository taskRepository, IMapper mapper)
    {
        _taskRepository = taskRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the GetTaskCommand request
    /// </summary>
    public async Task<List<ListTaskResult>> Handle(ListTaskCommand command, CancellationToken cancellationToken)
    {
        var tasks = await _taskRepository.TaskByProjectIdAsync(command.IdProject, cancellationToken);
        return tasks == null ? throw new KeyNotFoundException($"Tasks not found") : _mapper.Map<List<ListTaskResult>>(tasks);
    }
}

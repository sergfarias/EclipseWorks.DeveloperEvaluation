using AutoMapper;
using MediatR;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.CreateTask;

/// <summary>
/// Handler for processing CreateTaskCommand requests
/// </summary>
public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, CreateTaskResult>
{
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;
    
    /// <summary>
    /// Initializes a new instance of CreateTaskHandler
    /// </summary>
    public CreateTaskHandler(ITaskRepository  taskRepository,  IMapper mapper)
    {
        _taskRepository = taskRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CreateTaskCommand request
    /// </summary>
    public async Task<CreateTaskResult> Handle(CreateTaskCommand command, CancellationToken cancellationToken)
    {
        var task = _mapper.Map<Domain.Entities.Task>(command);
      
        task.Id = Guid.NewGuid();
        task.Status = Domain.Enums.TaskStatus.Pending;
        task.CreatedAt = DateTime.Now;
       
        var createdTask = await _taskRepository.CreateAsync(task, cancellationToken);
        var result = _mapper.Map<CreateTaskResult>(createdTask);
        return result;
    }
}

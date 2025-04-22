using AutoMapper;
using MediatR;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
using EclipseWorks.DeveloperEvaluation.Domain.Entities;
using EclipseWorks.DeveloperEvaluation.Application.Histories.CreateHistory;
using System.Threading.Tasks;

namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.CreateTask;

/// <summary>
/// Handler for processing CreateHistoryCommand requests
/// </summary>
public class CreateHistoryHandler : IRequestHandler<CreateHistoryCommand, CreateHistoryResult>
{
    private readonly IHistoryRepository _historyRepository;
    private readonly IProjectRepository _projectRepository;
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;
    
    /// <summary>
    /// Initializes a new instance of CreateHistoryHandler
    /// </summary>
    /// <param name="historyRepository">The history repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public CreateHistoryHandler(IHistoryRepository historyRepository, IProjectRepository projectRepository, 
                                ITaskRepository taskRepository, IMapper mapper)
    {
        _historyRepository = historyRepository;
        _projectRepository = projectRepository;
        _taskRepository = taskRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the CreateHistoryCommand request
    /// </summary>
    /// <param name="command">The CreateHistory command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created history details</returns>
    public async Task<CreateHistoryResult> Handle(CreateHistoryCommand command, CancellationToken cancellationToken)
    {
        var history = _mapper.Map<History>(command);

        history.Id = Guid.NewGuid();
        history.CreatedAt = DateTime.Now;

        var task = await _taskRepository.GetByIdAsync(history.TaskId);
        if (task == null)
        {
            throw new KeyNotFoundException("Tarefa " + task?.Id + " não encontrado.");
        }

        var project = await _projectRepository.GetByIdAsync(task.ProjectId);
        if (project == null)
        {
            throw new KeyNotFoundException("Usuário do projeto " + project?.ProjectNumber + " não encontrado.");
        }

        history.CreatedUserId = project.UserId;


        var createdHistory = await _historyRepository.CreateAsync(history, cancellationToken);
        var result = _mapper.Map<CreateHistoryResult>(createdHistory);
        return result;
    }
}

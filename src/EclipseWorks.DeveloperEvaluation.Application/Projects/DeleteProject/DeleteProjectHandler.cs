using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
using FluentValidation;
using MediatR;

namespace EclipseWorks.DeveloperEvaluation.Application.Projects.DeleteProject;

/// <summary>
/// Handler for processing DeleteProjectCommand requests
/// </summary>
public class DeleteProjectHandler : IRequestHandler<DeleteProjectCommand, DeleteProjectResponse>
{
    private readonly IProjectRepository _projectRepository;
    private readonly ITaskRepository _taskRepository;
    /// <summary>
    /// Initializes a new instance of DeleteProjectHandler
    /// </summary>
    /// <param name="projectRepository">The project repository</param>
    /// <param name="taskRepository">The task repository</param>
    /// <param name="validator">The validator for DeleteProjectCommand</param>
    public DeleteProjectHandler(IProjectRepository projectRepository, ITaskRepository taskRepository)
    {
        _projectRepository = projectRepository;
        _taskRepository = taskRepository;
    }

    /// <summary>
    /// Handles the DeleteProjectCommand request
    /// </summary>
    public async Task<DeleteProjectResponse> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
    {
        var validator = new DeleteProjectValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var pendentes = await _taskRepository.TaskPendingByProjectIdAsync(request.Id, cancellationToken);
        if (pendentes != null)
        {
            throw new KeyNotFoundException("Projeto não pde ser removido pois tem tarefas pendentes. Conclua ou remova as tarefas pendentes:" + pendentes  );
        }

        var success = await _projectRepository.DeleteAsync(request.Id, cancellationToken);
        if (!success)
            throw new KeyNotFoundException($"User with ID {request.Id} not found");

        return new DeleteProjectResponse { Success = true };
    }
}

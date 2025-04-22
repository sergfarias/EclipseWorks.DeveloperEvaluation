using MediatR;
using FluentValidation;
using EclipseWorks.DeveloperEvaluation.Domain.Repositories;
namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.DeleteTask;

/// <summary>
/// Handler for processing DeleteUserCommand requests
/// </summary>
public class DeleteTaskHandler : IRequestHandler<DeleteTaskCommand, DeleteTaskResponse>
{
    private readonly ITaskRepository _taskRepository;
    /// <summary>
    /// Initializes a new instance of DeleteUserHandler
    /// </summary>
    public DeleteTaskHandler(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    /// <summary>
    /// Handles the DeleteTaskCommand request
    /// </summary>
    public async Task<DeleteTaskResponse> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
        var validator = new DeleteTaskValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);
       
        var success = await _taskRepository.DeleteTasksAsync(request.Id, cancellationToken);
        if (!success)
            throw new KeyNotFoundException($"Task with ID {request.Id} not found");

        return new DeleteTaskResponse { Success = true };
    }
}

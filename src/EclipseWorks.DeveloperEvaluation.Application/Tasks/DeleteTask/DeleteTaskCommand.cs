using MediatR;
namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.DeleteTask;

/// <summary>
/// Command for deleting a task
/// </summary>
public record DeleteTaskCommand : IRequest<DeleteTaskResponse>
{
    /// <summary>
    /// The unique identifier of the task to delete
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Initializes a new instance of DeleteTaskCommand
    /// </summary>
    /// <param name="id">The ID of the task to delete</param>
    public DeleteTaskCommand(Guid id)
    {
        Id = id;
    }
}

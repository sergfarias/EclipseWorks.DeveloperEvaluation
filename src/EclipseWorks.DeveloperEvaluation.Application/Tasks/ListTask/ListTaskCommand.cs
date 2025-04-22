using MediatR;
namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.ListTask;

/// <summary>
/// Command for cancelled a task.
/// </summary>
public class ListTaskCommand : IRequest<List<ListTaskResult>>
{
    /// <summary>
    /// Gets or sets the project for the project.
    /// </summary>
    public Guid IdProject { get; set; }

}
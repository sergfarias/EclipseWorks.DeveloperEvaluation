using MediatR;
namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.UpdateTask;

/// <summary>
/// Command for cancelled a task.
/// </summary>
/// <remarks>
public class UpdateTaskCommand : IRequest<UpdateTaskResult>
{
    public Guid Id { get; set; }

    public Domain.Enums.TaskStatus Status { get; set; }

    public string Details { get; set; } = string.Empty;

}
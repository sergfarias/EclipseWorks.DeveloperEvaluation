using EclipseWorks.DeveloperEvaluation.Domain.Enums;

namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.CreateTask;

/// <summary>
/// Represents the response returned after successfully creating a new task.
/// </summary>
public class CreateTaskResult
{
    public Guid Id { get; set; }

    public Guid ProjectId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Details { get; set; } = string.Empty;

    public DateTime DueDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public Domain.Enums.TaskStatus Status { get; set; }

    public Priority Priority { get; set; }
}

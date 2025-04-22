namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.ListTask;

/// <summary>
/// Represents the response returned after successfully creating a new task.
/// </summary>
public class ListTaskResult
{
    public Guid Id { get; set; }

    public Guid ProjectId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime DueDate { get; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}


using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.Application.Tasks.UpdateTask;

/// <summary>
/// Represents the response returned after successfully Cancelled a task.
/// </summary>
public class UpdateTaskResult
{
    public Guid ProjectId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Details { get; set; } = string.Empty;

    public DateTime DueDate { get; }

    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets the date and time of the last update to the item's information.
    /// </summary>
    //public DateTime? UpdatedAt { get; set; }

    public Domain.Enums.TaskStatus Status { get; set; }

    public Priority Priority { get; set; }

}

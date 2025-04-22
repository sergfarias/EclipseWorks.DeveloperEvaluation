using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.CreateTask;

/// <summary>
/// Represents a request to create a new task in the system.
/// </summary>
public class CreateTaskRequest
{
    public Guid ProjectId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Details { get; set; } = string.Empty;

    public DateTime DueDate { get; set; }

    public Priority Priority { get; set; }
}
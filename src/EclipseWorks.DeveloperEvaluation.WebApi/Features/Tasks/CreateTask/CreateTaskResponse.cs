using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.CreateTask;

/// <summary>
/// API response model for CreateTask operation
/// </summary>
public class CreateTaskResponse
{
    public Guid ProjectId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime DueDate { get; }

    public DateTime CreatedAt { get; set; }

    public Domain.Enums.TaskStatus Status { get; set; }

    public Priority Priority { get; set; }

}

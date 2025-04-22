using EclipseWorks.DeveloperEvaluation.Domain.Enums;

namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.UpdateTask;

/// <summary>
/// API response model for UpdateTask operation
/// </summary>
public class UpdateTaskResponse
{

    public Guid ProjectId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Details { get; set; } = string.Empty;

    public DateTime DueDate { get; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Domain.Enums.TaskStatus Status { get; set; }

    public Priority Priority { get; set; }

}

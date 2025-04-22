namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Tasks.ListTask;

/// <summary>
/// API response model for ListTask operation
/// </summary>
public class ListTaskResponse
{
    public Guid Id { get; set; }

    public Guid ProjectId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime DueDate { get; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

}

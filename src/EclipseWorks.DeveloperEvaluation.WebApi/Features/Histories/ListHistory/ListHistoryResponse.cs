namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Histories.ListHistory;

/// <summary>
/// API response model for ListHistory operation
/// </summary>
public class ListHistoryResponse
{
    public Guid Id { get; set; }

    public Guid TaskId { get; set; }

    public string Details { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}

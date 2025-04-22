using EclipseWorks.DeveloperEvaluation.Domain.Enums;
namespace EclipseWorks.DeveloperEvaluation.WebApi.Features.Histories.CreateHistory;

/// <summary>
/// API response model for CreateHistory operation
/// </summary>
public class CreateHistoryResponse
{
    public Guid TaskId { get; set; }

    public string Details { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public HistoryStatus Status { get; set; }

}
